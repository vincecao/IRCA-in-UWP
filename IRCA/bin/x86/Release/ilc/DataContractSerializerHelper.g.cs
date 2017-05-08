using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
        }
        static int[] s_knownContractsLists = new int[] {
              -1,   60,   62,   -1,   56,   57,   60,   -1, }
        ;
        // Count = 321
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                5, // array length: 5
                1786, // index: 1786, string: "HelpLink"
                1795, // index: 1795, string: "InnerException"
                1810, // index: 1810, string: "Message"
                1818, // index: 1818, string: "StackTrace"
                1829, // index: 1829, string: "Type"
                5, // array length: 5
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                4, // array length: 4
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                4, // array length: 4
                1834, // index: 1834, string: "Properties"
                1845, // index: 1845, string: "Attachments"
                1857, // index: 1857, string: "Messages"
                802, // index: 802, string: "TestCase"
                4, // array length: 4
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                1834, // index: 1834, string: "Properties"
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                -1, // string: null
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1866, // index: 1866, string: "key"
                1870, // index: 1870, string: "value"
                2, // array length: 2
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                6, // array length: 6
                1876, // index: 1876, string: "Attributes"
                1887, // index: 1887, string: "Category"
                1896, // index: 1896, string: "Description"
                1908, // index: 1908, string: "Id"
                1911, // index: 1911, string: "Label"
                1917, // index: 1917, string: "ValueType"
                6, // array length: 6
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                4, // array length: 4
                653, // index: 653, string: "None"
                658, // index: 658, string: "Hidden"
                665, // index: 665, string: "Immutable"
                675, // index: 675, string: "Trait"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                3, // array length: 3
                1845, // index: 1845, string: "Attachments"
                1927, // index: 1927, string: "DisplayName"
                1939, // index: 1939, string: "Uri"
                3, // array length: 3
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                1896, // index: 1896, string: "Description"
                1939, // index: 1939, string: "Uri"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                1887, // index: 1887, string: "Category"
                1943, // index: 1943, string: "Text"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                1834, // index: 1834, string: "Properties"
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1866, // index: 1866, string: "key"
                1870, // index: 1870, string: "value"
                2, // array length: 2
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                5, // array length: 5
                653, // index: 653, string: "None"
                956, // index: 956, string: "Passed"
                963, // index: 963, string: "Failed"
                970, // index: 970, string: "Skipped"
                978, // index: 978, string: "NotFound"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                1948, // index: 1948, string: "DateTime"
                1957, // index: 1957, string: "OffsetMinutes"
                2, // array length: 2
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                -1, // string: null
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                1971, // index: 1971, string: "ExecutedTests"
                1985, // index: 1985, string: "Stats"
                2, // array length: 2
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1218, // index: 1218, string: "Key"
                1222, // index: 1222, string: "Value"
                2, // array length: 2
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1866, // index: 1866, string: "key"
                1870, // index: 1870, string: "value"
                2, // array length: 2
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                508, // index: 508, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                1810, // index: 1810, string: "Message"
                1991, // index: 1991, string: "MessageLevel"
                2, // array length: 2
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                3, // array length: 3
                1424, // index: 1424, string: "Informational"
                1438, // index: 1438, string: "Warning"
                1446, // index: 1446, string: "Error"
                3, // array length: 3
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                3, // array length: 3
                2004, // index: 2004, string: "Data"
                1786, // index: 1786, string: "HelpLink"
                2009, // index: 2009, string: "Source"
                3, // array length: 3
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                1002, // index: 1002, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1218, // index: 1218, string: "Key"
                1222, // index: 1222, string: "Value"
                2, // array length: 2
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1218, // index: 1218, string: "Key"
                1222, // index: 1222, string: "Value"
                2, // array length: 2
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                3, // array length: 3
                2016, // index: 2016, string: "Contract"
                2025, // index: 2025, string: "InitParams"
                2036, // index: 2036, string: "TestRunParams"
                3, // array length: 3
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                6, // array length: 6
                1638, // index: 1638, string: "CancelTestRun"
                1652, // index: 1652, string: "InitializeConnection"
                653, // index: 653, string: "None"
                1673, // index: 1673, string: "Shutdown"
                1682, // index: 1682, string: "StartTestRun"
                1695, // index: 1695, string: "StartTestRunWithSources"
                2, // array length: 2
                -1, // string: null
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                2050, // index: 2050, string: "LoadOnlyWellKnownExtensions"
                2078, // index: 2078, string: "PathToAdditionalExtensions"
                2, // array length: 2
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                825, // index: 825, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                5, // array length: 5
                2105, // index: 2105, string: "DataCollectorServiceUri"
                2129, // index: 2129, string: "ExecutionContext"
                2146, // index: 2146, string: "Sources"
                2154, // index: 2154, string: "TestRunSettings"
                2170, // index: 2170, string: "Tests"
                5, // array length: 5
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                7, // array length: 7
                2176, // index: 2176, string: "AreTestCaseLevelEventsRequired"
                2207, // index: 2207, string: "FrequencyOfRunStatsChangeEvent"
                2238, // index: 2238, string: "InIsolation"
                2250, // index: 2250, string: "IsDebug"
                2258, // index: 2258, string: "KeepAlive"
                2268, // index: 2268, string: "RunStatsChangeEventTimeout"
                2295, // index: 2295, string: "TestCaseFilter"
                7, // array length: 7
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062, // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1062  // index: 1062, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
        };
        // Count = 18
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[] {
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 653, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 658, // Hidden
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 665, // Immutable
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 675, // Trait
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 653, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 956, // Passed
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 963, // Failed
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 970, // Skipped
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 978, // NotFound
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1424, // Informational
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1438, // Warning
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1446, // Error
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1638, // CancelTestRun
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1652, // InitializeConnection
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 653, // None
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1673, // Shutdown
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1682, // StartTestRun
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1695, // StartTestRunWithSources
                    Value = 5,
                }
        };
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=96
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                                "1d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.1.0.0, Culture=neutral, PublicKeyTok" +
                                "en=b03f5f7f11d50a3a")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestObject, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, V" +
                                "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.Obje" +
                                "ctModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 130, // 0x82
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ve" +
                                "rsion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 146, // 0x92
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 162, // 0xa2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 178, // 0xb2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.Ob" +
                                "jectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                "d50a3a")),
                    TableIndex = 194, // 0xc2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.IDictionary, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                "f11d50a3a")),
                    TableIndex = 210, // 0xd2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 226, // 0xe2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 242, // 0xf2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0" +
                                ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.InitializeConnectionParams, Microsoft.VisualStudio.TestPlatform.Core, V" +
                                "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.StartTestRunParams, Microsoft.VisualStudio.TestPlatform.Core, Version=1" +
                                "5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestExecutionContext, Microsoft.VisualStudio.TestPlatform.Core, Version" +
                                "=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 258, // 0x102
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 274, // 0x112
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 290, // 0x122
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "b03f5f7f11d50a3a")),
                    TableIndex = 306, // 0x132
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.ICollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 322, // 0x142
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 338, // 0x152
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                                    "1d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f1" +
                                    "1d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=22
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // ExceptionDetail
                        NamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        StableNameIndex = 255, // ExceptionDetail
                        StableNameNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        TopLevelElementNameIndex = 255, // ExceptionDetail
                        TopLevelElementNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.1.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.1.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type0.ReadExceptionDetailFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type1.WriteExceptionDetailToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 7,
                    MemberNamesListIndex = 9,
                    MemberNamespacesListIndex = 15,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 437, // TestResult
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 437, // TestResult
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 437, // TestResult
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        KnownDataContractsListIndex = 1,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type5.ReadTestResultFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type6.WriteTestResultToXml),
                    ChildElementNamespacesListIndex = 21,
                    ContractNamespacesListIndex = 26,
                    MemberNamesListIndex = 29,
                    MemberNamespacesListIndex = 34,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 448, // TestObject
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 448, // TestObject
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 448, // TestObject
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestObject, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestObject, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type7.ReadTestObjectFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type8.WriteTestObjectToXml),
                    ChildElementNamespacesListIndex = 39,
                    ContractNamespacesListIndex = 41,
                    MemberNamesListIndex = 43,
                    MemberNamespacesListIndex = 45,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type12.ReadKeyValuePairOfTestPropertyanyTypeGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type13.WriteKeyValuePairOfTestPropertyanyTypeGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 47,
                    ContractNamespacesListIndex = 50,
                    MemberNamesListIndex = 52,
                    MemberNamespacesListIndex = 55,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 617, // TestProperty
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 617, // TestProperty
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 617, // TestProperty
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, V" +
                                    "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, V" +
                                    "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type14.ReadTestPropertyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type15.WriteTestPropertyToXml),
                    ChildElementNamespacesListIndex = 58,
                    ContractNamespacesListIndex = 65,
                    MemberNamesListIndex = 67,
                    MemberNamespacesListIndex = 74,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 702, // AttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 702, // AttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 702, // AttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                    "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                    "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type19.ReadAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type20.WriteAttachmentSetToXml),
                    ChildElementNamespacesListIndex = 86,
                    ContractNamespacesListIndex = 90,
                    MemberNamesListIndex = 92,
                    MemberNamespacesListIndex = 96,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 741, // UriDataAttachment
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 741, // UriDataAttachment
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 741, // UriDataAttachment
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type24.ReadUriDataAttachmentFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type25.WriteUriDataAttachmentToXml),
                    ChildElementNamespacesListIndex = 100,
                    ContractNamespacesListIndex = 103,
                    MemberNamesListIndex = 105,
                    MemberNamespacesListIndex = 108,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 784, // TestResultMessage
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 784, // TestResultMessage
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 784, // TestResultMessage
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type32.ReadTestResultMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type33.WriteTestResultMessageToXml),
                    ChildElementNamespacesListIndex = 111,
                    ContractNamespacesListIndex = 114,
                    MemberNamesListIndex = 116,
                    MemberNamespacesListIndex = 119,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 802, // TestCase
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 802, // TestCase
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 802, // TestCase
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                    "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                    "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        KnownDataContractsListIndex = 4,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type37.ReadTestCaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type38.WriteTestCaseToXml),
                    ChildElementNamespacesListIndex = 122,
                    ContractNamespacesListIndex = 124,
                    MemberNamesListIndex = 127,
                    MemberNamespacesListIndex = 129,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 917, // KeyValuePairOfstringstring
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 917, // KeyValuePairOfstringstring
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 917, // KeyValuePairOfstringstring
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type45.ReadKeyValuePairOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type46.WriteKeyValuePairOfstringstringToXml),
                    ChildElementNamespacesListIndex = 131,
                    ContractNamespacesListIndex = 134,
                    MemberNamesListIndex = 136,
                    MemberNamespacesListIndex = 139,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 987, // DateTimeOffset
                        NamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        StableNameIndex = 987, // DateTimeOffset
                        StableNameNamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        TopLevelElementNameIndex = 987, // DateTimeOffset
                        TopLevelElementNamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTimeOffset, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                    "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type47.ReadDateTimeOffsetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type48.WriteDateTimeOffsetToXml),
                    ChildElementNamespacesListIndex = 148,
                    ContractNamespacesListIndex = 151,
                    MemberNamesListIndex = 153,
                    MemberNamespacesListIndex = 156,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1049, // TestRunStats
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1049, // TestRunStats
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1049, // TestRunStats
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type49.ReadTestRunStatsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type50.WriteTestRunStatsToXml),
                    ChildElementNamespacesListIndex = 159,
                    ContractNamespacesListIndex = 162,
                    MemberNamesListIndex = 164,
                    MemberNamespacesListIndex = 167,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type54.ReadKeyValueOfTestOutcomelongGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type55.WriteKeyValueOfTestOutcomelongGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 170,
                    ContractNamespacesListIndex = 173,
                    MemberNamesListIndex = 175,
                    MemberNamespacesListIndex = 178,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1228, // KeyValuePairOfTestOutcomelongGfygfmPv
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 1228, // KeyValuePairOfTestOutcomelongGfygfmPv
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 1228, // KeyValuePairOfTestOutcomelongGfygfmPv
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type56.ReadKeyValuePairOfTestOutcomelongGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type57.WriteKeyValuePairOfTestOutcomelongGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 181,
                    ContractNamespacesListIndex = 184,
                    MemberNamesListIndex = 186,
                    MemberNamespacesListIndex = 189,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1300, // LogMessage
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1300, // LogMessage
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1300, // LogMessage
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type64.ReadLogMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type65.WriteLogMessageToXml),
                    ChildElementNamespacesListIndex = 192,
                    ContractNamespacesListIndex = 195,
                    MemberNamesListIndex = 197,
                    MemberNamespacesListIndex = 200,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1452, // Exception
                        NamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        StableNameIndex = 1452, // Exception
                        StableNameNamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        TopLevelElementNameIndex = 1452, // Exception
                        TopLevelElementNamespaceIndex = 1002, // http://schemas.datacontract.org/2004/07/System
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type69.ReadExceptionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type70.WriteExceptionToXml),
                    ChildElementNamespacesListIndex = 207,
                    ContractNamespacesListIndex = 211,
                    MemberNamesListIndex = 213,
                    MemberNamespacesListIndex = 217,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1494, // KeyValueOfanyTypeanyType
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1494, // KeyValueOfanyTypeanyType
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1494, // KeyValueOfanyTypeanyType
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type74.ReadKeyValueOfanyTypeanyTypeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type75.WriteKeyValueOfanyTypeanyTypeToXml),
                    ChildElementNamespacesListIndex = 221,
                    ContractNamespacesListIndex = 224,
                    MemberNamesListIndex = 226,
                    MemberNamespacesListIndex = 229,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1549, // KeyValueOfstringstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1549, // KeyValueOfstringstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1549, // KeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type82.ReadKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type83.WriteKeyValueOfstringstringToXml),
                    ChildElementNamespacesListIndex = 232,
                    ContractNamespacesListIndex = 235,
                    MemberNamesListIndex = 237,
                    MemberNamespacesListIndex = 240,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1572, // PollRequest
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1572, // PollRequest
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1572, // PollRequest
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0" +
                                    ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0" +
                                    ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type84.ReadPollRequestFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type85.WritePollRequestToXml),
                    ChildElementNamespacesListIndex = 243,
                    ContractNamespacesListIndex = 247,
                    MemberNamesListIndex = 249,
                    MemberNamespacesListIndex = 253,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1719, // InitializeConnectionParams
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1719, // InitializeConnectionParams
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1719, // InitializeConnectionParams
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.InitializeConnectionParams, Microsoft.VisualStudio.TestPlatform.Core, V" +
                                    "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.InitializeConnectionParams, Microsoft.VisualStudio.TestPlatform.Core, V" +
                                    "ersion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type86.ReadInitializeConnectionParamsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type87.WriteInitializeConnectionParamsToXml),
                    ChildElementNamespacesListIndex = 264,
                    ContractNamespacesListIndex = 267,
                    MemberNamesListIndex = 269,
                    MemberNamespacesListIndex = 272,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1746, // StartTestRunParams
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1746, // StartTestRunParams
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1746, // StartTestRunParams
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.StartTestRunParams, Microsoft.VisualStudio.TestPlatform.Core, Version=1" +
                                    "5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.StartTestRunParams, Microsoft.VisualStudio.TestPlatform.Core, Version=1" +
                                    "5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type88.ReadStartTestRunParamsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type89.WriteStartTestRunParamsToXml),
                    ChildElementNamespacesListIndex = 275,
                    ContractNamespacesListIndex = 281,
                    MemberNamesListIndex = 283,
                    MemberNamespacesListIndex = 289,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1765, // TestExecutionContext
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1765, // TestExecutionContext
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1765, // TestExecutionContext
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestExecutionContext, Microsoft.VisualStudio.TestPlatform.Core, Version" +
                                    "=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestExecutionContext, Microsoft.VisualStudio.TestPlatform.Core, Version" +
                                    "=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type90.ReadTestExecutionContextFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type91.WriteTestExecutionContextToXml),
                    ChildElementNamespacesListIndex = 295,
                    ContractNamespacesListIndex = 303,
                    MemberNamesListIndex = 305,
                    MemberNamespacesListIndex = 313,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=22
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 331, // ArrayOfTestResult
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 331, // ArrayOfTestResult
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 331, // ArrayOfTestResult
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type2.ReadArrayOfTestResultFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type3.WriteArrayOfTestResultToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type4.ReadArrayOfTestResultFromXmlIsGetOnly),
                    CollectionItemNameIndex = 437, // TestResult
                    KeyNameIndex = -1,
                    ItemNameIndex = 437, // TestResult
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 459, // ArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPv
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 459, // ArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPv
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 459, // ArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPv
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type9.ReadArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type10.WriteArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPvToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type11.ReadArrayOfKeyValuePairOfTestPropertyanyTypeGfygfmPvFromXmlIsGetOnly),
                    CollectionItemNameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                    KeyNameIndex = -1,
                    ItemNameIndex = 575, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 681, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 681, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 681, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.Collection`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type16.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type17.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type18.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 702, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 702, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 716, // ArrayOfUriDataAttachment
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 716, // ArrayOfUriDataAttachment
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 716, // ArrayOfUriDataAttachment
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type21.ReadArrayOfUriDataAttachmentFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type22.WriteArrayOfUriDataAttachmentToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type23.ReadArrayOfUriDataAttachmentFromXmlIsGetOnly),
                    CollectionItemNameIndex = 741, // UriDataAttachment
                    KeyNameIndex = -1,
                    ItemNameIndex = 741, // UriDataAttachment
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 681, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 681, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 681, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1, System.ObjectModel, Version=4.0.10.0, Culture=neutral, Pu" +
                                    "blicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type26.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type27.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type28.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 702, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 702, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 759, // ArrayOfTestResultMessage
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 759, // ArrayOfTestResultMessage
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 759, // ArrayOfTestResultMessage
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.Collection`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type29.ReadArrayOfTestResultMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type30.WriteArrayOfTestResultMessageToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type31.ReadArrayOfTestResultMessageFromXmlIsGetOnly),
                    CollectionItemNameIndex = 784, // TestResultMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 784, // TestResultMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 759, // ArrayOfTestResultMessage
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 759, // ArrayOfTestResultMessage
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 759, // ArrayOfTestResultMessage
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1, System.ObjectModel, Version=4.0.10.0, Culture=neutral, Pu" +
                                    "blicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type34.ReadArrayOfTestResultMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type35.WriteArrayOfTestResultMessageToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type36.ReadArrayOfTestResultMessageFromXmlIsGetOnly),
                    CollectionItemNameIndex = 784, // TestResultMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 784, // TestResultMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 811, // ArrayOfstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 811, // ArrayOfstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 811, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type39.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type40.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type41.ReadArrayOfstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 883, // ArrayOfKeyValuePairOfstringstring
                        NamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 883, // ArrayOfKeyValuePairOfstringstring
                        StableNameNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 883, // ArrayOfKeyValuePairOfstringstring
                        TopLevelElementNamespaceIndex = 508, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type42.ReadArrayOfKeyValuePairOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type43.WriteArrayOfKeyValuePairOfstringstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type44.ReadArrayOfKeyValuePairOfstringstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 917, // KeyValuePairOfstringstring
                    KeyNameIndex = -1,
                    ItemNameIndex = 917, // KeyValuePairOfstringstring
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1143, // ArrayOfKeyValueOfTestOutcomelongGfygfmPv
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1143, // ArrayOfKeyValueOfTestOutcomelongGfygfmPv
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1143, // ArrayOfKeyValueOfTestOutcomelongGfygfmPv
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type51.ReadArrayOfKeyValueOfTestOutcomelongGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type52.WriteArrayOfKeyValueOfTestOutcomelongGfygfmPvToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type53.ReadArrayOfKeyValueOfTestOutcomelongGfygfmPvFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                    KeyNameIndex = 1218, // Key
                    ItemNameIndex = 1184, // KeyValueOfTestOutcomelongGfygfmPv
                    ValueNameIndex = 1222, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1266, // ArrayOfTestCase
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 1266, // ArrayOfTestCase
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 1266, // ArrayOfTestCase
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type58.ReadArrayOfTestCaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type59.WriteArrayOfTestCaseToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type60.ReadArrayOfTestCaseFromXmlIsGetOnly),
                    CollectionItemNameIndex = 802, // TestCase
                    KeyNameIndex = -1,
                    ItemNameIndex = 802, // TestCase
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1282, // ArrayOfLogMessage
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1282, // ArrayOfLogMessage
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1282, // ArrayOfLogMessage
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type61.ReadArrayOfLogMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type62.WriteArrayOfLogMessageToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type63.ReadArrayOfLogMessageFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1300, // LogMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 1300, // LogMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 811, // ArrayOfstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 811, // ArrayOfstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 811, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type66.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type67.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type68.ReadArrayOfstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1462, // ArrayOfKeyValueOfanyTypeanyType
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1462, // ArrayOfKeyValueOfanyTypeanyType
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1462, // ArrayOfKeyValueOfanyTypeanyType
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.IDictionary, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.IDictionary, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type71.ReadArrayOfKeyValueOfanyTypeanyTypeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type72.WriteArrayOfKeyValueOfanyTypeanyTypeToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type73.ReadArrayOfKeyValueOfanyTypeanyTypeFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1494, // KeyValueOfanyTypeanyType
                    KeyNameIndex = 1218, // Key
                    ItemNameIndex = 1494, // KeyValueOfanyTypeanyType
                    ValueNameIndex = 1222, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Dictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 681, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 681, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 681, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type76.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type77.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type78.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 702, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 702, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type79.ReadArrayOfKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type80.WriteArrayOfKeyValueOfstringstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type81.ReadArrayOfKeyValueOfstringstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1549, // KeyValueOfstringstring
                    KeyNameIndex = 1218, // Key
                    ItemNameIndex = 1549, // KeyValueOfstringstring
                    ValueNameIndex = 1222, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 331, // ArrayOfTestResult
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 331, // ArrayOfTestResult
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 331, // ArrayOfTestResult
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type92.ReadArrayOfTestResultFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type93.WriteArrayOfTestResultToXml),
                    CollectionItemNameIndex = 437, // TestResult
                    KeyNameIndex = -1,
                    ItemNameIndex = 437, // TestResult
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1266, // ArrayOfTestCase
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 1266, // ArrayOfTestCase
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 1266, // ArrayOfTestCase
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type94.ReadArrayOfTestCaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type95.WriteArrayOfTestCaseToXml),
                    CollectionItemNameIndex = 802, // TestCase
                    KeyNameIndex = -1,
                    ItemNameIndex = 802, // TestCase
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                "on=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1282, // ArrayOfLogMessage
                        NamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1282, // ArrayOfLogMessage
                        StableNameNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1282, // ArrayOfLogMessage
                        TopLevelElementNamespaceIndex = 1062, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type96.ReadArrayOfLogMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type97.WriteArrayOfLogMessageToXml),
                    CollectionItemNameIndex = 1300, // LogMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 1300, // LogMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0.0," +
                                " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 811, // ArrayOfstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 811, // ArrayOfstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 811, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type98.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type99.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type100.ReadArrayOfstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericCollection,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 681, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 681, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 681, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.ICollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.ICollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type101.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type102.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type103.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 702, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 702, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericCollection,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        NamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        StableNameNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1519, // ArrayOfKeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 825, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IDictionary`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type104.ReadArrayOfKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type105.WriteArrayOfKeyValueOfstringstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type106.ReadArrayOfKeyValueOfstringstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1549, // KeyValueOfstringstring
                    KeyNameIndex = 1218, // Key
                    ItemNameIndex = 1549, // KeyValueOfstringstring
                    ValueNameIndex = 1222, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=4
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[] {
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 630, // TestPropertyAttributes
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 630, // TestPropertyAttributes
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 630, // TestPropertyAttributes
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.Obje" +
                                    "ctModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.Obje" +
                                    "ctModel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    IsFlags = true,
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 81,
                    MemberCount = 4,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 944, // TestOutcome
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 944, // TestOutcome
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 944, // TestOutcome
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ve" +
                                    "rsion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ve" +
                                    "rsion=15.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 142,
                    MemberCount = 5,
                    MemberListIndex = 4,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1311, // TestMessageLevel
                        NamespaceIndex = 1328, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging
                        StableNameIndex = 1311, // TestMessageLevel
                        StableNameNamespaceIndex = 1328, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging
                        TopLevelElementNameIndex = 1311, // TestMessageLevel
                        TopLevelElementNamespaceIndex = 1328, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.Ob" +
                                    "jectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.Ob" +
                                    "jectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 203,
                    MemberCount = 3,
                    MemberListIndex = 9,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1584, // ContractName
                        NamespaceIndex = 1597, // Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1584, // ContractName
                        StableNameNamespaceIndex = 1597, // Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1584, // ContractName
                        TopLevelElementNamespaceIndex = 1597, // Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=15.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 257,
                    MemberCount = 6,
                    MemberListIndex = 12,
                }
        };
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','E','x','c','e','p','t','i','o','n','D','e','t','a','i','l',
            '\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o',
            'r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e','m','.','S','e','r','v','i','c','e','M','o','d','e','l',
            '\0','A','r','r','a','y','O','f','T','e','s','t','R','e','s','u','l','t','\0','h','t','t','p',':','/','/','s','c','h','e',
            'm','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M',
            'i','c','r','o','s','o','f','t','.','V','i','s','u','a','l','S','t','u','d','i','o','.','T','e','s','t','P','l','a','t',
            'f','o','r','m','.','O','b','j','e','c','t','M','o','d','e','l','\0','T','e','s','t','R','e','s','u','l','t','\0','T','e',
            's','t','O','b','j','e','c','t','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','P','a','i','r','O','f',
            'T','e','s','t','P','r','o','p','e','r','t','y','a','n','y','T','y','p','e','G','f','y','g','f','m','P','v','\0','h','t',
            't','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/',
            '2','0','0','4','/','0','7','/','S','y','s','t','e','m','.','C','o','l','l','e','c','t','i','o','n','s','.','G','e','n',
            'e','r','i','c','\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','T','e','s','t','P','r','o','p','e','r','t',
            'y','a','n','y','T','y','p','e','G','f','y','g','f','m','P','v','\0','T','e','s','t','P','r','o','p','e','r','t','y','\0',
            'T','e','s','t','P','r','o','p','e','r','t','y','A','t','t','r','i','b','u','t','e','s','\0','N','o','n','e','\0','H','i',
            'd','d','e','n','\0','I','m','m','u','t','a','b','l','e','\0','T','r','a','i','t','\0','A','r','r','a','y','O','f','A','t',
            't','a','c','h','m','e','n','t','S','e','t','\0','A','t','t','a','c','h','m','e','n','t','S','e','t','\0','A','r','r','a',
            'y','O','f','U','r','i','D','a','t','a','A','t','t','a','c','h','m','e','n','t','\0','U','r','i','D','a','t','a','A','t',
            't','a','c','h','m','e','n','t','\0','A','r','r','a','y','O','f','T','e','s','t','R','e','s','u','l','t','M','e','s','s',
            'a','g','e','\0','T','e','s','t','R','e','s','u','l','t','M','e','s','s','a','g','e','\0','T','e','s','t','C','a','s','e',
            '\0','A','r','r','a','y','O','f','s','t','r','i','n','g','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.',
            'm','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z',
            'a','t','i','o','n','/','A','r','r','a','y','s','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','P','a',
            'i','r','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','K','e','y','V','a','l','u','e','P','a','i','r','O',
            'f','s','t','r','i','n','g','s','t','r','i','n','g','\0','T','e','s','t','O','u','t','c','o','m','e','\0','P','a','s','s',
            'e','d','\0','F','a','i','l','e','d','\0','S','k','i','p','p','e','d','\0','N','o','t','F','o','u','n','d','\0','D','a','t',
            'e','T','i','m','e','O','f','f','s','e','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t',
            'a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e','m','\0','T',
            'e','s','t','R','u','n','S','t','a','t','s','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t',
            'a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f',
            't','.','V','i','s','u','a','l','S','t','u','d','i','o','.','T','e','s','t','P','l','a','t','f','o','r','m','.','C','o',
            'r','e','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','O','f','T','e','s','t','O','u','t','c','o','m',
            'e','l','o','n','g','G','f','y','g','f','m','P','v','\0','K','e','y','V','a','l','u','e','O','f','T','e','s','t','O','u',
            't','c','o','m','e','l','o','n','g','G','f','y','g','f','m','P','v','\0','K','e','y','\0','V','a','l','u','e','\0','K','e',
            'y','V','a','l','u','e','P','a','i','r','O','f','T','e','s','t','O','u','t','c','o','m','e','l','o','n','g','G','f','y',
            'g','f','m','P','v','\0','A','r','r','a','y','O','f','T','e','s','t','C','a','s','e','\0','A','r','r','a','y','O','f','L',
            'o','g','M','e','s','s','a','g','e','\0','L','o','g','M','e','s','s','a','g','e','\0','T','e','s','t','M','e','s','s','a',
            'g','e','L','e','v','e','l','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n',
            't','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','V','i',
            's','u','a','l','S','t','u','d','i','o','.','T','e','s','t','P','l','a','t','f','o','r','m','.','O','b','j','e','c','t',
            'M','o','d','e','l','.','L','o','g','g','i','n','g','\0','I','n','f','o','r','m','a','t','i','o','n','a','l','\0','W','a',
            'r','n','i','n','g','\0','E','r','r','o','r','\0','E','x','c','e','p','t','i','o','n','\0','A','r','r','a','y','O','f','K',
            'e','y','V','a','l','u','e','O','f','a','n','y','T','y','p','e','a','n','y','T','y','p','e','\0','K','e','y','V','a','l',
            'u','e','O','f','a','n','y','T','y','p','e','a','n','y','T','y','p','e','\0','A','r','r','a','y','O','f','K','e','y','V',
            'a','l','u','e','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','K','e','y','V','a','l','u','e','O','f','s',
            't','r','i','n','g','s','t','r','i','n','g','\0','P','o','l','l','R','e','q','u','e','s','t','\0','C','o','n','t','r','a',
            'c','t','N','a','m','e','\0','M','i','c','r','o','s','o','f','t','.','V','i','s','u','a','l','S','t','u','d','i','o','.',
            'T','e','s','t','P','l','a','t','f','o','r','m','.','C','o','r','e','\0','C','a','n','c','e','l','T','e','s','t','R','u',
            'n','\0','I','n','i','t','i','a','l','i','z','e','C','o','n','n','e','c','t','i','o','n','\0','S','h','u','t','d','o','w',
            'n','\0','S','t','a','r','t','T','e','s','t','R','u','n','\0','S','t','a','r','t','T','e','s','t','R','u','n','W','i','t',
            'h','S','o','u','r','c','e','s','\0','I','n','i','t','i','a','l','i','z','e','C','o','n','n','e','c','t','i','o','n','P',
            'a','r','a','m','s','\0','S','t','a','r','t','T','e','s','t','R','u','n','P','a','r','a','m','s','\0','T','e','s','t','E',
            'x','e','c','u','t','i','o','n','C','o','n','t','e','x','t','\0','H','e','l','p','L','i','n','k','\0','I','n','n','e','r',
            'E','x','c','e','p','t','i','o','n','\0','M','e','s','s','a','g','e','\0','S','t','a','c','k','T','r','a','c','e','\0','T',
            'y','p','e','\0','P','r','o','p','e','r','t','i','e','s','\0','A','t','t','a','c','h','m','e','n','t','s','\0','M','e','s',
            's','a','g','e','s','\0','k','e','y','\0','v','a','l','u','e','\0','A','t','t','r','i','b','u','t','e','s','\0','C','a','t',
            'e','g','o','r','y','\0','D','e','s','c','r','i','p','t','i','o','n','\0','I','d','\0','L','a','b','e','l','\0','V','a','l',
            'u','e','T','y','p','e','\0','D','i','s','p','l','a','y','N','a','m','e','\0','U','r','i','\0','T','e','x','t','\0','D','a',
            't','e','T','i','m','e','\0','O','f','f','s','e','t','M','i','n','u','t','e','s','\0','E','x','e','c','u','t','e','d','T',
            'e','s','t','s','\0','S','t','a','t','s','\0','M','e','s','s','a','g','e','L','e','v','e','l','\0','D','a','t','a','\0','S',
            'o','u','r','c','e','\0','C','o','n','t','r','a','c','t','\0','I','n','i','t','P','a','r','a','m','s','\0','T','e','s','t',
            'R','u','n','P','a','r','a','m','s','\0','L','o','a','d','O','n','l','y','W','e','l','l','K','n','o','w','n','E','x','t',
            'e','n','s','i','o','n','s','\0','P','a','t','h','T','o','A','d','d','i','t','i','o','n','a','l','E','x','t','e','n','s',
            'i','o','n','s','\0','D','a','t','a','C','o','l','l','e','c','t','o','r','S','e','r','v','i','c','e','U','r','i','\0','E',
            'x','e','c','u','t','i','o','n','C','o','n','t','e','x','t','\0','S','o','u','r','c','e','s','\0','T','e','s','t','R','u',
            'n','S','e','t','t','i','n','g','s','\0','T','e','s','t','s','\0','A','r','e','T','e','s','t','C','a','s','e','L','e','v',
            'e','l','E','v','e','n','t','s','R','e','q','u','i','r','e','d','\0','F','r','e','q','u','e','n','c','y','O','f','R','u',
            'n','S','t','a','t','s','C','h','a','n','g','e','E','v','e','n','t','\0','I','n','I','s','o','l','a','t','i','o','n','\0',
            'I','s','D','e','b','u','g','\0','K','e','e','p','A','l','i','v','e','\0','R','u','n','S','t','a','t','s','C','h','a','n',
            'g','e','E','v','e','n','t','T','i','m','e','o','u','t','\0','T','e','s','t','C','a','s','e','F','i','l','t','e','r','\0'
            };
    }
}
