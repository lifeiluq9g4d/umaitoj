//    This file is part of QTTabBar, a shell extension for Microsoft
//    Windows Explorer.
//    Copyright (C) 2007-2021  Quizo, Paul Accisano
//
//    QTTabBar is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    QTTabBar is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with QTTabBar.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Runtime.InteropServices;

namespace QTPlugin.Interop {
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("000214F2-0000-0000-C000-000000000046")]
    public interface IEnumIDList {
        [PreserveSig]
        int Next(uint celt, out IntPtr rgelt, out IntPtr pceltFetched);
        [PreserveSig]
        int Skip(uint celt);
        [PreserveSig]
        int Reset();
        [PreserveSig]
        int Clone(out IEnumIDList ppenum);
    }
}
