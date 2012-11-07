//------------------------------------------------------------------------------
// <copyright file="CodeBinaryOperatorType.cs" company="Microsoft">
//     
//      Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//     
//      The use and distribution terms for this software are contained in the file
//      named license.txt, which can be found in the root of this distribution.
//      By using this software in any fashion, you are agreeing to be bound by the
//      terms of this license.
//     
//      You must not remove this notice, or any other, from this software.
//     
// </copyright>                                                                
//------------------------------------------------------------------------------

namespace System.CodeDom {
    using System.Runtime.Remoting;

    using System.Diagnostics;
    using System;
    using Microsoft.Win32;
    using System.Collections;
    using System.Runtime.InteropServices;

    /// <devdoc>
    ///    <para>
    ///       Specifies type identifiers for supported binary operators.
    ///    </para>
    /// </devdoc>
    [
        ComVisible(true),
        Serializable,
    ]
    public enum CodeBinaryOperatorType {
        /// <devdoc>
        ///    <para>
        ///       Addition operator.
        ///    </para>
        /// </devdoc>
        Add,
        /// <devdoc>
        ///    <para>
        ///       Subtraction operator.
        ///    </para>
        /// </devdoc>
        Subtract,
        /// <devdoc>
        ///    <para>
        ///       Multiplication operator.
        ///    </para>
        /// </devdoc>
        Multiply,
        /// <devdoc>
        ///    <para>
        ///       Division operator.
        ///    </para>
        /// </devdoc>
        Divide,
        /// <devdoc>
        ///    <para>
        ///       Modulus operator.
        ///    </para>
        /// </devdoc>
        Modulus,
        /// <devdoc>
        ///    <para>
        ///       Assignment operator.
        ///    </para>
        /// </devdoc>
        Assign,
        /// <devdoc>
        ///    <para>
        ///       Identity not equal operator.
        ///    </para>
        /// </devdoc>
        IdentityInequality,
        /// <devdoc>
        ///    <para>
        ///       Identity equal operator.
        ///    </para>
        /// </devdoc>
        IdentityEquality,
        /// <devdoc>
        ///    <para>
        ///       Value equal operator.
        ///    </para>
        /// </devdoc>
        ValueEquality,
        /// <devdoc>
        ///    <para>
        ///       Bitwise or operator.
        ///    </para>
        /// </devdoc>
        BitwiseOr,
        /// <devdoc>
        ///    <para>
        ///       Bitwise and operator.
        ///    </para>
        /// </devdoc>
        BitwiseAnd,
        /// <devdoc>
        ///    <para>
        ///       Boolean or operator.
        ///    </para>
        /// </devdoc>
        BooleanOr,
        /// <devdoc>
        ///    <para>
        ///       Boolean and operator.
        ///    </para>
        /// </devdoc>
        BooleanAnd,
        /// <devdoc>
        ///    <para>
        ///       Less than operator.
        ///    </para>
        /// </devdoc>
        LessThan,
        /// <devdoc>
        ///    <para>
        ///       Less than or equal operator.
        ///    </para>
        /// </devdoc>
        LessThanOrEqual,
        /// <devdoc>
        ///    <para>
        ///       Greater than operator.
        ///    </para>
        /// </devdoc>
        GreaterThan,
        /// <devdoc>
        ///    <para>
        ///       Greater that or operator.
        ///    </para>
        /// </devdoc>
        GreaterThanOrEqual,
    }
}