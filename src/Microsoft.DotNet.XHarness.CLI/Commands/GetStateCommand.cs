﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.DotNet.XHarness.Common.CLI.CommandArguments;
using Microsoft.DotNet.XHarness.Common.CLI.Commands;

namespace Microsoft.DotNet.XHarness.CLI.Commands
{
    internal abstract class GetStateCommand<TArguments> : XHarnessCommand<TArguments> where TArguments : IXHarnessCommandArguments
    {
        private const string CommandHelp = "Print information about the current machine, such as host machine info and device status";
        protected override string CommandDescription { get; } = CommandHelp;

        public GetStateCommand() : base("state", allowsExtraArgs: false, CommandHelp)
        {
        }
    }
}
