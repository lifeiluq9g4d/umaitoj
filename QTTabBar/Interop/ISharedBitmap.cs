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
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;

namespace QTTabBarLib.Interop {
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), SuppressUnmanagedCodeSecurity, Guid("091162a4-bc96-411f-aae8-c5122cd03363")]
    public interface ISharedBitmap {
        [PreserveSig]
        int GetSharedBitmap(out IntPtr phbm);
        [PreserveSig]
        int GetSize(out Size pSize);
        [PreserveSig]
        int GetFormat(out uint pat);
        [PreserveSig]
        int InitializeBitmap(IntPtr hbm, uint wtsAT);
        [PreserveSig]
        int Detach(out IntPtr phbm);
    }
}
