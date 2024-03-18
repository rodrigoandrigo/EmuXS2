# EmuXS2
Sketch 2 of what an x86 uwp emulator made in C# would look like using "Template Studio for UWP"

# folders
ConPTY: https://github.com/rodrigoandrigo/Terminal-UWP

VCPU: where the x86 processor will be located using Iced to create it

# Pages
MainPage: project home page

TermiPage: ConPTY terminal

ScreenPage: page where the screen will be rendered using CanvasControl

SettingsPage: settings

# Nuget Package
https://www.nuget.org/packages/Iced

https://www.nuget.org/packages/Win2D.uwp

# iced usage examples

using Iced.Intel
https://github.com/vezel-dev/ruptura/blob/e0b49102b7f262db4ab2aff8c9b8ed7283bf5d05/src/memory/Code/FunctionHook.cs
https://github.com/mbbsemu/MBBSEmu/blob/22685cc84dadc98a6b15d2449901bfac8892a66b/MBBSEmu/CPU/CpuRegisters.cs
https://github.com/mbbsemu/MBBSEmu/blob/22685cc84dadc98a6b15d2449901bfac8892a66b/MBBSEmu/Disassembler/ModuleDisassembly.cs
https://github.com/ashmind/SharpLab/blob/572d95d642f06eb7f058a40d18f0b92bebe5fb92/source/Server/Decompilation/Internal/MemoryCodeReader.cs
https://github.com/WhiteBlackGoose/CodegenAnalysis/blob/3881dda8fe7f0dd7565a9de8abf21c476b5daa53/Sources/CodegenAnalysis/CodegenAnalyzers.cs
https://github.com/WhiteBlackGoose/CodegenAnalysis/blob/3881dda8fe7f0dd7565a9de8abf21c476b5daa53/Sources/CodegenAnalysis/Disassembler.cs
https://github.com/dnSpyEx/dnSpy/blob/6b7d3c545e27178b58b13d138087cb094c6a422d/Extensions/dnSpy.Debugger/dnSpy.Debugger/AntiAntiDebug/CloseHandlePatcherX86.cs
https://github.com/dnSpyEx/dnSpy/blob/6b7d3c545e27178b58b13d138087cb094c6a422d/Extensions/dnSpy.Debugger/dnSpy.Debugger/AntiAntiDebug/IsDebuggerPresentPatcherX86.cs
https://github.com/dnSpyEx/dnSpy/blob/6b7d3c545e27178b58b13d138087cb094c6a422d/dnSpy/dnSpy/Disassembly/X86/DisassemblySettingsUtils.cs
https://github.com/dnSpyEx/dnSpy/blob/6b7d3c545e27178b58b13d138087cb094c6a422d/dnSpy/dnSpy/Disassembly/Viewer/X86/RegisterUtils.cs
https://github.com/dnSpyEx/dnSpy/blob/6b7d3c545e27178b58b13d138087cb094c6a422d/Extensions/dnSpy.Debugger/dnSpy.Debugger/AntiAntiDebug/CheckRemoteDebuggerPresentPatcherX86.cs

