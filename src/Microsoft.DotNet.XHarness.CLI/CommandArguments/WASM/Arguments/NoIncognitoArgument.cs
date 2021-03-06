﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.DotNet.XHarness.Common.CLI.CommandArguments;

namespace Microsoft.DotNet.XHarness.CLI.CommandArguments.Wasm
{
    internal class NoIncognitoArgument : SwitchArgument
    {
        public NoIncognitoArgument()
            : base("no-incognito", "Don't run in incognito mode", true)
        {
        }
    }
}
