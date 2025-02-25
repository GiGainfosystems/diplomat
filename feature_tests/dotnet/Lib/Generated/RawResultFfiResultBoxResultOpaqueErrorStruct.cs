// Automatically generated by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using DiplomatFeatures.Diplomat;
#pragma warning restore 0105

namespace DiplomatFeatures.Raw;

#nullable enable

[StructLayout(LayoutKind.Sequential)]
public partial struct ResultFfiResultBoxResultOpaqueErrorStruct
{
    [StructLayout(LayoutKind.Explicit)]
    private unsafe struct InnerUnion
    {
        [FieldOffset(0)]
        internal ResultOpaque* ok;
        [FieldOffset(0)]
        internal ErrorStruct err;
    }

    private InnerUnion _inner;

    [MarshalAs(UnmanagedType.U1)]
    public bool isOk;

    public unsafe ResultOpaque* Ok
    {
        get
        {
            return _inner.ok;
        }
    }

    public unsafe ErrorStruct Err
    {
        get
        {
            return _inner.err;
        }
    }
}
