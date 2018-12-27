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

I have successfully built and run the code on Windows 7 and Windows 10.

You might need to change the path in [`build.bat`](./build.bat) to find a
suitable `csc.exe` on your system.
Obvious changes would be to use a different version number, or to use
`Framework64` instead of `Framework64`.
