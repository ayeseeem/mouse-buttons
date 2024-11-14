Mouse Button Swapper
====================

Simple program to quickly swap the mouse buttons (on Windows).

The change is only temporary - it is not retained when you log out.

It is useful if you normally use swapped mouse buttons and you share a desktop
with someone who doesn't - for example an IT help desk.

It was originally inspired by answers on
<http://stackoverflow.com/questions/4806575/how-do-i-use-rundll32-to-SwapMouseButton>,
particularly <https://stackoverflow.com/a/4806576>
and <https://stackoverflow.com/a/10509038>.

I have successfully built and run the code on Windows 7, Windows 10, and Windows 11.

You might need to change the path in [`build.bat`](./build.bat) to find a
suitable `csc.exe` on your system.
Obvious changes would be to use a different version number, or to use
`Framework64` instead of `Framework`.

At the moment, it attempts to use the latest .NET Framework 4.x.
The build file includes a commented out example for the very old .NET Framework 3.5.
See the
[.NET Support Policy](https://dotnet.microsoft.com/en-us/platform/support/policy)
for more.


License
-------

This work is dual-licensed under Apache 2.0 and GPL 2.0 (or any later version).
You can choose between one of them if you use this work.

`SPDX-License-Identifier: Apache-2.0 OR GPL-2.0-or-later`

Alternative licensing arrangements are possible, contact us for details.


Installation
------------

Very useful if you "right-click"`*` on the `.exe` and then "Pin to Taskbar".

Edit the properties (via "right-click") to change the icon: use a system
icon for a mouse - look in the default `shell32.dll`, or in
`DDORes.dll`, both found in `%SystemRoot%\System32\`.

If you want to set the name/tooltip for the Taskbar button, the easiest way is
not to pin the `.exe` itself. Instead, create a shortcut to it, rename the
shortcut to something more expressive (like "Swap mouse buttons"), set the icon
on the shortcut, then pin the _shortcut_ to the Taskbar.

- `*` "right-click" depends on which way you have your mouse set, which can
  become confusing.
  Also, "right-click" should really be "Alt-click", but people interpret that
  as "Press the Alt button and click".
  Left-handed mouse users presumably get used to this.
