﻿using System.DirectoryServices.ActiveDirectory;

namespace myADMonitor.Models
{
    public class ADPropertySyntaxAndType
    {
        public ActiveDirectorySyntax ADSyntax { get; set; }
        public bool IsSingleValued { get; set; }
    }
}
