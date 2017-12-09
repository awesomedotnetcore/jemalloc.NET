﻿using System;
using System.Collections.Generic;
using System.Text;

using CommandLine;
using CommandLine.Text;

namespace jemalloc.Cli
{
    class Options
    {

    }

    [Verb("malloc", HelpText = "Benchmark data structures backed by native memory allocated using jemalloc vs. .NET managed arrays, vectors, and tensors.")]
    class MallocBenchmarkOptions : Options
    {
        [Option('u', "unsigned", Required = false, HelpText = "Use the unsigned version of the underlying data type.")]
        public bool Unsigned { get; set; }

        [Option('s', "int16", Required = false, HelpText = "Use Int16 integers as the underlying data type.")]
        public bool Int16 { get; set; }

        [Option('i', "int32", Required = false, HelpText = "Use Int32 integers as the underlying data type.")]
        public bool Int32 { get; set; }

        [Option('l', "int64", Required = false, HelpText = "Use Int64 integers as the underlying data type.")]
        public bool Int64 { get; set; }

        [Value(0, Required = true, HelpText = "The sizes of data structures to benchmark.")]
        public IEnumerable<int> Sizes { get; set; }

    }


}
