// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Urf">
//     Copyright (c) Urf. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Urf
{
    using System;
    using System.ComponentModel.Composition.Hosting;
    using System.Reflection;

    using PlaySharp.Toolkit.AppDomain.Legacy;

    // called at assembly load
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod());
        }
    }

    // called at post configure
    public class TestLibrary : ILibrary
    {
        public void Configure(CompositionContainer container)
        {
            Console.WriteLine(MethodBase.GetCurrentMethod());
        }

        public void Unload()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod());
        }
    }

    // called at game start
    public class TestAssembly : IAssembly
    {
        public void Activate()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod());
        }

        public void Deactivate()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod());
        }
    }
}