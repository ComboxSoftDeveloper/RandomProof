## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.NextBench.WithoutSeed()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FF867DA5E78]; RandomProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FF867C7A618]; System.Random+XoshiroImpl.Next()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.Next()
M02_L00:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       rax,r11
       shr       rax,21
       cmp       rax,7FFFFFFF
       je        short M02_L00
       ret
; Total bytes of code 86
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.NextBench.WithSeed()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FF867D75F68]; RandomProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       add       rcx,8
       call      qword ptr [7FF867D75FB0]; System.Random+CompatPrng.InternalSample()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 78
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M02_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M02_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.NextBench.Shared()
       mov       rcx,1ED840014A0
       mov       rcx,[rcx]
       jmp       qword ptr [7FF867D75F80]; RandomProof.Subjects.Next(System.Random)
; Total bytes of code 19
```
```assembly
; RandomProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random+ThreadSafeRandom
       cmp       [rcx],rax
       jne       short M01_L04
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],5
       jle       short M01_L03
       mov       rcx,[rcx+240]
       mov       rax,[rcx+28]
       test      rax,rax
       je        short M01_L03
M01_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M01_L01
       call      qword ptr [7FF867D760D0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M01_L01:
       cmp       [rcx],ecx
       call      qword ptr [7FF867C4A618]; System.Random+XoshiroImpl.Next()
M01_L02:
       nop
       add       rsp,28
       ret
M01_L03:
       mov       ecx,5
       call      qword ptr [7FF867D7C390]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M01_L00
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L02
; Total bytes of code 114
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FF8AF243778]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8AF24D778]; Precode of System.Random+XoshiroImpl..ctor()
       call      qword ptr [7FF8AF23AEA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FF8AF238FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; System.Random+XoshiroImpl.Next()
M03_L00:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       rax,r11
       shr       rax,21
       cmp       rax,7FFFFFFF
       je        short M03_L00
       ret
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8AF251D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.NextBench.Crypto()
       jmp       qword ptr [7FF867D75E78]; RandomProof.Subjects.CryptoNext()
; Total bytes of code 6
```
```assembly
; RandomProof.Subjects.CryptoNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF867D8F9A8
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF90C5C3670
       call      rax
M01_L01:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF8C78D3A90],0
       je        short M01_L02
       call      qword ptr [7FF8C78C2648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rbx+8],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M01_L03
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,[rbp-3C]
       and       eax,3FF
       cmp       eax,3E7
       ja        near ptr M01_L00
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       call      qword ptr [7FF867D7C3C0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 233
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.NextBench.WithoutSeed()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FF845F5C000]; RandomProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FF845DAC6F8]; System.Random+XoshiroImpl.Next()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.Next()
M02_L00:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       lea       r9,[rdx+rdx*4]
       rol       r9,7
       lea       r9,[r9+r9*8]
       mov       r11,rdx
       shl       r11,11
       xor       r8,rax
       xor       r10,rdx
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r11
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       rax,r9
       shr       rax,21
       cmp       rax,7FFFFFFF
       je        short M02_L00
       ret
; Total bytes of code 86
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.NextBench.WithSeed()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FF845F7CBE8]; RandomProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       add       rcx,8
       call      qword ptr [7FF845DE55A8]; System.Random+CompatPrng.InternalSample()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 78
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M02_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M02_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.NextBench.Shared()
       mov       rcx,1D5D78002A8
       mov       rcx,[rcx]
       jmp       qword ptr [7FF845F6C000]; RandomProof.Subjects.Next(System.Random)
; Total bytes of code 19
```
```assembly
; RandomProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random+ThreadSafeRandom
       cmp       [rcx],rax
       jne       short M01_L05
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],2
       jl        short M01_L04
       mov       rax,[rax+198]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M01_L04
       mov       rax,[rax]
       add       rax,10
M01_L00:
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M01_L02
M01_L01:
       cmp       [rcx],ecx
       call      qword ptr [7FF845DBC6F8]; System.Random+XoshiroImpl.Next()
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF845F6C108]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
       jmp       short M01_L01
M01_L03:
       add       rsp,28
       ret
M01_L04:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L00
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L03
; Total bytes of code 122
```
```assembly
; System.Random+XoshiroImpl.Next()
M02_L00:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       lea       r9,[rdx+rdx*4]
       rol       r9,7
       lea       r9,[r9+r9*8]
       mov       r11,rdx
       shl       r11,11
       xor       r8,rax
       xor       r10,rdx
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r11
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       rax,r9
       shr       rax,21
       cmp       rax,7FFFFFFF
       je        short M02_L00
       ret
; Total bytes of code 86
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FF892EDC1A0]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF892EE4DF0]; Precode of System.Random+XoshiroImpl..ctor()
       call      qword ptr [7FF892ED5470]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF892ED3D30]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 50
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.NextBench.Crypto()
       jmp       qword ptr [7FF845F4CC78]; RandomProof.Subjects.CryptoNext()
; Total bytes of code 6
```
```assembly
; RandomProof.Subjects.CryptoNext()
       sub       rsp,28
       xor       ecx,ecx
       mov       edx,3E8
       call      qword ptr [7FF845F4CDC8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 23
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ebx,ebx
       mov       [rbp-48],rbx
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       cmp       ebx,esi
       jge       near ptr M02_L05
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L06
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
       lea       r15,[rbp-3C]
       mov       [rbp-50],r15
M02_L00:
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF845F3EEB0
       mov       [rbp-80],rax
       lea       rax,[M02_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rdi+10],rax
       mov       byte ptr [rdi+0C],0
       mov       rax,7FF90C5C3670
       call      rax
M02_L01:
       mov       byte ptr [rdi+0C],1
       cmp       dword ptr [7FF8A599917C],0
       je        short M02_L02
       call      qword ptr [7FF8A59893C8]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-88]
       mov       [rdi+10],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M02_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       mov       r15,[rbp-50]
       ja        near ptr M02_L00
       add       eax,ebx
M02_L03:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       call      qword ptr [7FF845F4DB00]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M02_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF845FA4510]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF845ADF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L06:
       mov       eax,ebx
       jmp       short M02_L03
; Total bytes of code 366
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.NextBench.WithoutSeed()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FF845EC4EB8]; RandomProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FF845D5F3B8]; System.Random+XoshiroImpl.Next()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.Next()
M02_L00:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       rax,r11
       shr       rax,21
       cmp       rax,7FFFFFFF
       je        short M02_L00
       ret
; Total bytes of code 86
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.NextBench.WithSeed()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FF845ED4DE0]; RandomProof.Subjects.Next(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       add       rcx,8
       call      qword ptr [7FF845ED4E28]; System.Random+CompatPrng.InternalSample()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 78
```
```assembly
; System.Random+CompatPrng.InternalSample()
       sub       rsp,28
       mov       eax,[rcx+8]
       inc       eax
       mov       edx,1
       cmp       eax,38
       cmovge    eax,edx
       mov       edx,[rcx+0C]
       inc       edx
       mov       r8d,1
       cmp       edx,38
       cmovge    edx,r8d
       mov       r8,[rcx]
       mov       r10d,[r8+8]
       cmp       eax,r10d
       jae       short M02_L00
       mov       r9d,eax
       mov       r11d,[r8+r9*4+10]
       cmp       edx,r10d
       jae       short M02_L00
       mov       r10d,edx
       sub       r11d,[r8+r10*4+10]
       mov       r10d,7FFFFFFE
       cmp       r11d,7FFFFFFF
       cmove     r11d,r10d
       lea       r10d,[r11+7FFFFFFF]
       test      r11d,r11d
       cmovl     r11d,r10d
       mov       [r8+r9*4+10],r11d
       mov       [rcx+8],eax
       mov       [rcx+0C],edx
       mov       eax,r11d
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 127
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.NextBench.Shared()
       mov       rcx,29BCBC014B0
       mov       rcx,[rcx]
       jmp       qword ptr [7FF845ED4ED0]; RandomProof.Subjects.Next(System.Random)
; Total bytes of code 19
```
```assembly
; RandomProof.Subjects.Next(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random+ThreadSafeRandom
       cmp       [rcx],rax
       jne       short M01_L05
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+208],5
       jle       short M01_L04
       mov       rax,[rax+210]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M01_L04
M01_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M01_L03
M01_L01:
       cmp       [rcx],ecx
       call      qword ptr [7FF845D6F3B8]; System.Random+XoshiroImpl.Next()
M01_L02:
       nop
       add       rsp,28
       ret
M01_L03:
       call      qword ptr [7FF845ED5020]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
       jmp       short M01_L01
M01_L04:
       mov       ecx,5
       call      CORINFO_HELP_GETDYNAMIC_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M01_L00
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L02
; Total bytes of code 115
```
```assembly
; System.Random+XoshiroImpl.Next()
M02_L00:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       rax,r11
       shr       rax,21
       cmp       rax,7FFFFFFF
       je        short M02_L00
       ret
; Total bytes of code 86
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FF892ECB030]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF892ED4AA0]; Precode of System.Random+XoshiroImpl..ctor()
       call      qword ptr [7FF892EC2B58]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FF892EC10F0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.NextBench.Crypto()
       jmp       qword ptr [7FF8526A4DE0]; RandomProof.Subjects.CryptoNext()
; Total bytes of code 6
```
```assembly
; RandomProof.Subjects.CryptoNext()
       sub       rsp,28
       xor       ecx,ecx
       mov       edx,3E8
       call      qword ptr [7FF8526A4DF8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       nop
       add       rsp,28
       ret
; Total bytes of code 23
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M02_L06
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M02_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF8526B9870
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF90C5C3670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF8B218C744],0
       je        short M02_L02
       call      qword ptr [7FF8B217A418]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       mov       ecx,eax
       test      ecx,ecx
       jne       short M02_L04
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M02_L00
       add       eax,ebx
M02_L03:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L04:
       call      qword ptr [7FF8526A7450]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF8526A7438]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF85248F7C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```

