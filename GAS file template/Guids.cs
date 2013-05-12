// Guids.cs
// MUST match guids.h
using System;

namespace MortenEngelhardtOlsen.GAS_file_template
{
    static class GuidList
    {
        public const string guidGAS_file_templatePkgString = "ea10eeb4-eb1e-4c55-beba-99a23c5a45e7";
        public const string guidGAS_file_templateCmdSetString = "11a62976-a0f8-4981-8a00-8e44f26ed414";

        public static readonly Guid guidGAS_file_templateCmdSet = new Guid(guidGAS_file_templateCmdSetString);
    };
}