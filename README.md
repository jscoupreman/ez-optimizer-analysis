# EZ Optimizer binary analysis
Recently I saw the following tweet:
> Let me introduce you EZ Optimizer for Cyberpunk 2077 by CodeZ1LLa!
Boosts the performance up to 30 FPS, allowing you to play the game even on a low-end PC with a decent graphics quality!
Watch the guide and download it here: https://t.co/lirmuqE32S#Cyberpunk2077 @CyberpunkGame
> 
> — Yuri Bubliy (@1usmus) December 26, 2020

It seems that the EZ Optimizer tool promises extraordinary performance improvements. At the same time, several websites have reported that the binary is potentially malicious. I decided to dig a little deeper and find what the binary actually does.

The binary has the following hashes:
- MD5: 9d2dc1ab2e4468859d878ef4f3439151
- SHA1: fa589e36ffc947038ede544b5b1dd5ca8d101ce8
- SHA256: ecf0a5cb6a7f191b1f039520d36cf4b343661c10bd927f168665e2deb51e5ab9
- SHA512: 3665ad0ea0170de6748eff3fa5f01164e4c948f9ef5e0f269c137624e5867647b1d04139122f31d597e5a9d0ea6c409efd301adca127de8ebc4b505a603a5c50

# TL;DR - Summary
[TODO]

# Analyses
## Static Analysis
### Basics
First, let's see what type of file is the binary file:
```
$ file CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe
CyberPunk EZ Optimizer V1.0 by CodeZ1LLa.exe: PE32 executable (GUI) Intel 80386 Mono/.Net assembly, for MS Windows
```
It is a PE 32 bits. Let's see if we gather interesting strings:
```
$ strings CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe
.text
`.rsrc
@.reloc
`AsI
BSJB
v4.0.30319
#Strings
#GUID
#Blob
label1
Form1
button1
groupBox1
label2
button2
label3
button3
label4
button4
label5
button5
label6
label7
button9
[...]
button1_Click
button2_Click
button3_Click
button4_Click
button5_Click
label6_Click
button9_Click
add_Click
Label
[...]
.NETFramework,Version=v4.8
[...]
C:\Users\Admin\source\repos\CyberPunk EZ Optimizer\obj\Debug\CyberPunk EZ Optimizer.pdb
[...]
<assemblyIdentity version="1.0.0.0" name="MyApplication.app"/>
<security>
    <requestedPrivileges xmlns="urn:schemas-microsoft-com:asm.v3">
        <requestedExecutionLevel level="asInvoker" uiAccess="false"/>
    </requestedPrivileges>
</security>
[...]
```
At first glance, nothing fancy. I see several Window components objects, no obfuscated strings (base64 encoded strings), no Powershell nor other suspicious code that a dropper could contain. However, several people reported that the PE creates one or several .ini files. I don't see any strings related to such settings in plain text, probably due to a compression mechanism.

### pecheck.py
pecheck.py is a wrapper for pefile, made by [Didier Stevens](https://blog.didierstevens.com/2013/04/19/3462/). The current version is 0.7.10.
```
>pecheck.py -l P "CyberPunk EZ Optimizer V1.0 by CodeZ1LLa.exe"
1: 0x00000000 EXE 64-bit 0x000121ff 9d2dc1ab2e4468859d878ef4f3439151 0x000121ff (EOF)

>pecheck.py -l 1 -o s "CyberPunk EZ Optimizer V1.0 by CodeZ1LLa.exe"
1: .text         44544 3.744238 Code Section
2: .rsrc         28672 1.664468 Resource section
3: .reloc          512 0.081539 Relocations Section

>pecheck.py -o r "CyberPunk EZ Optimizer V1.0 by CodeZ1LLa.exe"
   1: [RT_ICON]            1                    (0,0)   16936 2800000040000000 (...@...
   2: [RT_ICON]            2                    (0,0)    4264 2800000020000000 (... ...
   3: [RT_ICON]            3                    (0,0)    2440 2800000018000000 (.......
   4: [RT_ICON]            4                    (0,0)    1720 2800000014000000 (.......
   5: [RT_ICON]            5                    (0,0)    1128 2800000010000000 (.......
   6: [RT_GROUP_ICON]      32512                (0,0)      76 0000010005004040 ......@@
   7: [RT_VERSION]         1                    (0,0)     908 8c03340000005600 ..4...V.
   8: [RT_MANIFEST]        1                    (0,0)     490 efbbbf3c3f786d6c ...<?xml
```


### pefile
pefile is a small library and tool to list and extract resources from Portable Executable (PE) files. The project is hosted on [Github](https://github.com/folbricht/pefile).
```
$ pe list-resources CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe
3/1/0
3/2/0
3/3/0
3/4/0
3/5/0
14/32512/0
16/1/0
24/1/0
```

Let's extract resources:
```
$ pe extract-resource CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe 3/1/0 resources/RT_ICON_1.bin
$ pe extract-resource CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe 3/2/0 resources/RT_ICON_2.bin
$ pe extract-resource CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe 3/3/0 resources/RT_ICON_3.bin
$ pe extract-resource CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe 3/4/0 resources/RT_ICON_4.bin
$ pe extract-resource CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe 3/5/0 resources/RT_ICON_5.bin
$ pe extract-resource CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe 14/32512/0 resources/RT_ICON_32512.bin
$ pe extract-resource CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe 16/1/0 resources/RT_VERSION_1.bin
$ pe extract-resource CyberPunk\ EZ\ Optimizer\ V1.0\ by\ CodeZ1LLa.exe 24/1/0 resources/RT_MANIFEST_1.bin
```

Let's see what kind of file we extracted:
```
$ file resources/*
RT_ICON_1.bin:     dBase III DBT, version number 0, next free block index 40
RT_ICON_2.bin:     dBase III DBT, version number 0, next free block index 40
RT_ICON_32512.bin: data
RT_ICON_3.bin:     dBase III DBT, version number 0, next free block index 40
RT_ICON_4.bin:     dBase III DBT, version number 0, next free block index 40
RT_ICON_5.bin:     GLS_BINARY_LSB_FIRST
RT_MANIFEST_1.bin: XML 1.0 document, UTF-8 Unicode (with BOM) text, with CRLF line terminators
RT_VERSION_1.bin:  PGP symmetric key encrypted data - Plaintext or unencrypted data
```
[TODO]

### DIE
[TODO]

### dnSpy
As seen before, the PE looks like a .Net compiled binary. Let's analyse the source code with [dnSpy](https://github.com/dnSpy/dnSpy):

[TODO]


## Dynamic Analysis
### VirusTotal
CLEAN - VirusTotal reported the binary being clean. 0/71 engines triggered. The report is available [here](https://www.virustotal.com/gui/file/ecf0a5cb6a7f191b1f039520d36cf4b343661c10bd927f168665e2deb51e5ab9/detection)

[TODO]

## Behavior Analysis
The tool provides 4 game configurations:
- Balanced: Add a specific user.ini file within the `engine/config/platform/pc` folder.
- Default: Remove the user.ini file within the `engine/config/platform/pc` folder.
- Disable: Add a specific user.ini file within the `engine/config/platform/pc` folder.
- Max Boost: Add a specific user.ini file within the `engine/config/platform/pc` folder.

Each `user.ini` files contain several settings. Some are specific to the choosen configuration, some are common to all configurations. Each of the files are available in a respective folder, in this repository.
Following is a list of specific settings based on the choosen configuration, sorted by sections:
### [Developer/FeatureToggles]
Setting | Balanced | Disabled | Max Boost
--- | --- | --- | ---
Antialiasing | True | True | True
Bloom | True | True | True
CharacterLightBlockers | False | True | False
CharacterRimEnhancement | False | True | False
CharacterSubsurfaceScattering | True | True | True
ChromaticAberration | True | True | True
ConstrastAdaptiveSharpening | True | True | True
ContactShadows | True | True | True
DepthOfField | True | True | True
DistantFog | False | True | False
DistantGI | False | True | False
DistantShadows | True | True | True
DistantVolFog | False | True | False
DynamicDecals | True | True | True
FilmGrain | True | True | True
GlobalIllumination | True | True | True
Hair | True | True | True
ImageBasedFlares | True | True | True
LocalShadows | True | True | True
MotionBlur | False | True | False
RainMap | True | True | True
RuntimeTangentUpdate | False | True | False
ScreenSpaceHeatHaze | False | True | False
ScreenSpacePlanarReflection | False | True | False
ScreenSpaceRain | False | True | False
ScreenSpaceReflection | False | True | False
ScreenSpaceUnderwater | False | True | False
SSAO | True | True | True
VolumetricClouds | False | True | False
VolumetricFog | True | False | False
Weather | True | True | True

### [Rendering/AsyncCompute]
Setting | Balanced | Disabled | Max Boost
--- | --- | --- | ---
BuildDepthChain | False | False | False
DynamicTexture | False | False | False
Enable | False | False | False
FlattenNormals | False | False | False
LutGeneration | False | False | False
RaytraceASBuild | False | False | False
SSAO | False | False | False

### [Rendering/FrostedGlass]
Setting | Balanced | Disabled | Max Boost
--- | --- | --- | ---
GlassUseMipChain | True | True | True

### [Rendering]
Setting | Balanced | Disabled | Max Boost
--- | --- | --- | ---
RainMapProxySorting | True | True | True
UseExperimentalVolFog | False | True | False
UseSkinningLOD | True | True | True

### [Rendering/Shadows]
Setting | Balanced | Disabled | Max Boost
--- | --- | --- | ---
CascadeFitToWorstCase | True | True | True
CascadeUseBackfacesAsCullingPlanes | True | True | True

# Conclusion
[TODO]