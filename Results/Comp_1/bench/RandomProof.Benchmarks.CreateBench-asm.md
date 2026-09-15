## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.CreateBench.WithoutSeed()
       jmp       qword ptr [7FF867D65D58]; RandomProof.Subjects.CreateWithoutSeed()
; Total bytes of code 6
```
```assembly
; RandomProof.Subjects.CreateWithoutSeed()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,offset MT_System.Random
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Random+XoshiroImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF867D65E90]; System.Random+XoshiroImpl..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; System.Random+XoshiroImpl..ctor()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       mov       rax,0BD7A84FAC42C
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-80],rdx
       mov       rdx,rbp
       mov       [rbp-70],rdx
       mov       [rbp-0A0],rbx
       lea       rdx,[rbp-60]
       xor       ecx,ecx
       mov       r8d,20
       mov       r9d,2
       mov       rax,7FF867D7E418
       mov       [rbp-88],rax
       lea       rax,[M02_L00]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF90C5C3670
       call      rax
M02_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8C78D3A90],0
       je        short M02_L01
       call      qword ptr [7FF8C78C2648]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rdx,[rbp-90]
       mov       [rsi+8],rdx
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       mov       rdx,[rbp-60]
       mov       rbx,[rbp-0A0]
       mov       [rbx+8],rdx
       mov       rcx,[rbp-58]
       mov       [rbx+10],rcx
       mov       r8,[rbp-50]
       mov       [rbx+18],r8
       mov       r9,[rbp-48]
       mov       [rbx+20],r9
       or        rdx,rcx
       or        rdx,r8
       or        rdx,r9
       je        short M02_L04
       mov       r8,0BD7A84FAC42C
       cmp       [rbp-40],r8
       je        short M02_L03
       call      CORINFO_HELP_FAIL_FAST
M02_L03:
       nop
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
       lea       rdx,[rbp-60]
       xor       ecx,ecx
       mov       r8d,20
       mov       r9d,2
       mov       rax,7FF867D7E418
       mov       [rbp-88],rax
       lea       rax,[M02_L05]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF90C5C3670
       call      rax
M02_L05:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8C78D3A90],0
       je        short M02_L06
       call      qword ptr [7FF8C78C2648]; CORINFO_HELP_STOP_FOR_GC
M02_L06:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       test      eax,eax
       je        near ptr M02_L02
M02_L07:
       cmp       eax,0C0000017
       jne       short M02_L08
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF867D6C108]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF867D6C120]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 476
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.CreateBench.WithSeed()
       jmp       qword ptr [7FF867D85E48]; RandomProof.Subjects.CreateWithSeed()
; Total bytes of code 6
```
```assembly
; RandomProof.Subjects.CreateWithSeed()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Random
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Random+CompatSeedImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rdi,[rsi+8]
       cmp       qword ptr [rdi],0
       jne       near ptr M01_L10
       mov       rcx,offset MT_System.Int32[]
       mov       edx,38
       call      CORINFO_HELP_NEWARR_1_VC
       mov       ecx,9A4EC5C
       mov       dword ptr [rax+0EC],9A4EC5C
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,36
       jmp       short M01_L02
       nop       dword ptr [rax]
M01_L00:
       add       edx,7FFFFFFF
M01_L01:
       mov       ecx,[rax+r8*4+10]
       dec       r10d
       mov       r8d,r9d
       je        short M01_L04
M01_L02:
       add       r8d,15
       mov       r9d,r8d
       cmp       r9d,37
       jl        short M01_L03
       lea       r9d,[r8-37]
M01_L03:
       cmp       r9d,38
       jae       near ptr M01_L11
       mov       r8d,r9d
       mov       [rax+r8*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M01_L01
       jmp       short M01_L00
M01_L04:
       mov       ecx,4
       jmp       short M01_L06
       nop       dword ptr [rax+rax]
M01_L05:
       dec       ecx
       je        short M01_L09
M01_L06:
       mov       edx,1
       mov       r8d,1F
       jmp       short M01_L08
M01_L07:
       inc       edx
       cmp       edx,38
       jge       short M01_L05
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M01_L08
       add       r8d,0FFFFFFC9
M01_L08:
       mov       r10d,edx
       lea       r10,[rax+r10*4+10]
       mov       r9,r10
       mov       r11d,[r9]
       inc       r8d
       cmp       r8d,38
       jae       short M01_L11
       sub       r11d,[rax+r8*4+10]
       mov       [r9],r11d
       test      r11d,r11d
       jge       short M01_L07
       add       r11d,7FFFFFFF
       mov       [r10],r11d
       jmp       short M01_L07
M01_L09:
       mov       rcx,rdi
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],ecx
       mov       dword ptr [rdi+0C],15
M01_L10:
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 329
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.CreateBench.WithoutSeed()
       jmp       qword ptr [7FF852727090]; RandomProof.Subjects.CreateWithoutSeed()
; Total bytes of code 6
```
```assembly
; RandomProof.Subjects.CreateWithoutSeed()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Random
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF852594E70]; System.Random..ctor()
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 41
```
```assembly
; System.Random..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rbx
       mov       rcx,offset MT_System.Random
       cmp       [rsi],rcx
       jne       short M02_L01
       mov       rcx,offset MT_System.Random+XoshiroImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF8527270C0]; System.Random+XoshiroImpl..ctor()
M02_L00:
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF8526B4900]
       jmp       short M02_L00
; Total bytes of code 108
```

## .NET 8.0.31 (8.0.31, 8.0.3126.42015), X64 RyuJIT x86-64-v3 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.CreateBench.WithSeed()
       jmp       qword ptr [7FF8527273D8]; RandomProof.Subjects.CreateWithSeed()
; Total bytes of code 6
```
```assembly
; RandomProof.Subjects.CreateWithSeed()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,offset MT_System.Random
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Random+Net5CompatSeedImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       mov       edx,2A
       call      qword ptr [7FF8526B4750]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       mov       rdx,rsi
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,38
       call      CORINFO_HELP_NEWARR_1_VC
       cmp       esi,80000000
       je        near ptr M02_L09
       test      esi,esi
       jl        near ptr M02_L08
M02_L00:
       mov       ecx,esi
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,1
M02_L01:
       add       r8d,15
       cmp       r8d,37
       jl        short M02_L02
       add       r8d,0FFFFFFC9
M02_L02:
       cmp       r8d,38
       jae       near ptr M02_L10
       mov       r9d,r8d
       mov       [rax+r9*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L03
       add       edx,7FFFFFFF
M02_L03:
       mov       ecx,[rax+r9*4+10]
       inc       r10d
       cmp       r10d,37
       jl        short M02_L01
       mov       ecx,1
M02_L04:
       mov       edx,1
M02_L05:
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L06
       add       r8d,0FFFFFFC9
M02_L06:
       mov       r10d,edx
       lea       r10,[rax+r10*4+10]
       mov       r9d,[r10]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L10
       sub       r9d,[rax+r8*4+10]
       mov       [r10],r9d
       test      r9d,r9d
       jge       short M02_L07
       mov       r8d,edx
       lea       r8,[rax+r8*4+10]
       add       r9d,7FFFFFFF
       mov       [r8],r9d
M02_L07:
       inc       edx
       cmp       edx,38
       jl        short M02_L05
       inc       ecx
       cmp       ecx,5
       jl        short M02_L04
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L08:
       neg       esi
       jns       near ptr M02_L00
       call      qword ptr [7FF85266D1E8]
       int       3
M02_L09:
       mov       esi,7FFFFFFF
       jmp       near ptr M02_L00
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 291
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.CreateBench.WithoutSeed()
       jmp       qword ptr [7FF8526A4CC0]; RandomProof.Subjects.CreateWithoutSeed()
; Total bytes of code 6
```
```assembly
; RandomProof.Subjects.CreateWithoutSeed()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Random
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8526A4CD8]; System.Random..ctor()
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 41
```
```assembly
; System.Random..ctor()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Random
       cmp       [rbx],rcx
       jne       short M02_L01
       mov       rcx,offset MT_System.Random+XoshiroImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF8526A4DF8]; System.Random+XoshiroImpl..ctor()
       mov       rdx,rsi
M02_L00:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       rcx,offset MT_System.Random+Net5CompatDerivedImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8526A71F8]
       mov       rdx,rsi
       jmp       short M02_L00
; Total bytes of code 106
```

## .NET 9.0.20 (9.0.20, 9.0.2026.41315), X64 RyuJIT x86-64-v3 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.CreateBench.WithSeed()
       jmp       qword ptr [7FF8526A4D98]; RandomProof.Subjects.CreateWithSeed()
; Total bytes of code 6
```
```assembly
; RandomProof.Subjects.CreateWithSeed()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,offset MT_System.Random
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Random+Net5CompatSeedImpl
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       cmp       qword ptr [rcx],0
       jne       short M01_L00
       mov       edx,2A
       call      qword ptr [7FF8525CDDA0]; System.Random+CompatPrng.Initialize(Int32)
M01_L00:
       mov       rdx,rsi
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 85
```
```assembly
; System.Random+CompatPrng.Initialize(Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,offset MT_System.Int32[]
       mov       edx,38
       call      CORINFO_HELP_NEWARR_1_VC
       cmp       esi,80000000
       je        near ptr M02_L11
       mov       edi,esi
       test      edi,edi
       jl        near ptr M02_L08
M02_L00:
       mov       ecx,edi
       neg       ecx
       add       ecx,9A4EC86
       mov       [rax+0EC],ecx
       mov       edx,1
       xor       r8d,r8d
       mov       r10d,36
M02_L01:
       add       r8d,15
       mov       r9d,r8d
       cmp       r9d,37
       jge       near ptr M02_L09
M02_L02:
       cmp       r9d,38
       jae       near ptr M02_L12
       mov       r8d,r9d
       mov       [rax+r8*4+10],edx
       sub       ecx,edx
       mov       edx,ecx
       test      edx,edx
       jge       short M02_L03
       add       edx,7FFFFFFF
M02_L03:
       mov       ecx,[rax+r8*4+10]
       dec       r10d
       mov       r8d,r9d
       jne       short M02_L01
       mov       ecx,4
M02_L04:
       mov       edx,1
M02_L05:
       lea       r8d,[rdx+1E]
       cmp       r8d,37
       jl        short M02_L06
       add       r8d,0FFFFFFC9
M02_L06:
       lea       r10,[rax+rdx*4+10]
       mov       r9d,[r10]
       inc       r8d
       cmp       r8d,38
       jae       short M02_L12
       sub       r9d,[rax+r8*4+10]
       mov       [r10],r9d
       test      r9d,r9d
       jge       short M02_L07
       lea       r8,[rax+rdx*4+10]
       add       r9d,7FFFFFFF
       mov       [r8],r9d
M02_L07:
       inc       edx
       cmp       edx,38
       jl        short M02_L05
       dec       ecx
       jne       short M02_L04
       mov       rcx,rbx
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],eax
       mov       dword ptr [rbx+0C],15
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L08:
       mov       edi,esi
       neg       edi
       jns       near ptr M02_L00
       jmp       short M02_L10
M02_L09:
       lea       r9d,[r8-37]
       jmp       near ptr M02_L02
M02_L10:
       call      qword ptr [7FF8526A70A8]
       int       3
M02_L11:
       mov       edi,7FFFFFFF
       jmp       near ptr M02_L00
M02_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 301
```

