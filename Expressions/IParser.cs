﻿using System;
using System.Collections.Generic;
using System.Text;
using Expressions.Ast;

namespace Expressions
{
    internal interface IParser
    {
        ParseResult Parse(string expression);
    }
}