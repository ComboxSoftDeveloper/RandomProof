## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.MethodsBench.RangeWithout()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFEAFC8FBD0]; RandomProof.Subjects.NextRange(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextRange(System.Random)
       sub       rsp,28
       mov       rdx,offset MT_System.Random
       cmp       [rcx],rdx
       jne       near ptr M01_L05
       mov       rcx,[rcx+8]
       mov       rdx,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rdx
       jne       near ptr M01_L04
       mov       rdx,[rcx+8]
       mov       r8,[rcx+10]
       mov       rax,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,r8
       shl       r9,11
       xor       rax,rdx
       xor       r10,r8
       lea       r11,[r8+r8*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       r8,rax
       xor       rdx,r10
       xor       rax,r9
       rol       r10,2D
       mov       [rcx+8],rdx
       mov       [rcx+10],r8
       mov       [rcx+18],rax
       mov       [rcx+20],r10
       shr       r11,20
       mov       edx,r11d
       imul      rax,rdx,3E8
       mov       edx,eax
       cmp       edx,3E8
       jb        short M01_L02
M01_L00:
       shr       rax,20
M01_L01:
       add       rsp,28
       ret
M01_L02:
       cmp       edx,128
       jae       short M01_L00
M01_L03:
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
       shr       r11,20
       mov       edx,r11d
       imul      rax,rdx,3E8
       mov       edx,eax
       cmp       edx,128
       jb        short M01_L03
       jmp       short M01_L00
M01_L04:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M01_L01
M01_L05:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
; Total bytes of code 299
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.MethodsBench.RangeWith()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFEAFC5FCA8]; RandomProof.Subjects.NextRange(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextRange(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       add       rcx,8
       call      qword ptr [7FFEAFC5FCF0]; System.Random+CompatPrng.InternalSample()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FFEAF928380]
       vmulsd    xmm0,xmm0,qword ptr [7FFEAF928388]
       vcvttsd2si eax,xmm0
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L00
M01_L02:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L00
; Total bytes of code 121
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.MethodsBench.DoubleWithout()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFEAFC5FCA8]; RandomProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextDouble(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFEAFB3D680]; System.Random+XoshiroImpl.NextDouble()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.NextDouble()
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
       shr       r11,0B
       vxorps    xmm0,xmm0,xmm0
       vcvtusi2sd xmm0,xmm0,r11
       vmulsd    xmm0,xmm0,qword ptr [7FFEAF928280]
       ret
; Total bytes of code 93
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.MethodsBench.DoubleWith()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFEAFC7FCA8]; RandomProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextDouble(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       add       rcx,8
       call      qword ptr [7FFEAFC7FCF0]; System.Random+CompatPrng.InternalSample()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FFEAF948310]
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L00
; Total bytes of code 93
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.MethodsBench.Int64Without()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFEAFC7FCA8]; RandomProof.Subjects.NextInt64(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextInt64(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFEAFB5D660]; System.Random+XoshiroImpl.NextInt64()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L00
; Total bytes of code 73
```
```assembly
; System.Random+XoshiroImpl.NextInt64()
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
       shr       rax,1
       mov       rdx,7FFFFFFFFFFFFFFF
       cmp       rax,rdx
       je        short M02_L00
       ret
; Total bytes of code 92
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.MethodsBench.Int64With()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFEAFC6FCA8]; RandomProof.Subjects.NextInt64(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextInt64(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFEAFB4DBD0]; System.Random+CompatSeedImpl.NextInt64()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L00
; Total bytes of code 73
```
```assembly
; System.Random+CompatSeedImpl.NextInt64()
       push      rsi
       push      rbx
       sub       rsp,28
       vmovsd    xmm0,qword ptr [7FFEAF938778]
       vmovsd    xmm1,qword ptr [7FFEAF938780]
       vmovsd    xmm2,qword ptr [7FFEAF938788]
M02_L00:
       cmp       [rcx],cl
       lea       rax,[rcx+8]
       mov       rdx,rax
       mov       r8d,[rdx+8]
       inc       r8d
       cmp       r8d,38
       jl        short M02_L01
       mov       r8d,1
M02_L01:
       mov       r10d,[rdx+0C]
       inc       r10d
       cmp       r10d,38
       jl        short M02_L02
       mov       r10d,1
M02_L02:
       mov       r9,[rdx]
       mov       r11d,[r9+8]
       cmp       r8d,r11d
       jae       near ptr M02_L13
       mov       ebx,r8d
       mov       ebx,[r9+rbx*4+10]
       cmp       r10d,r11d
       jae       near ptr M02_L13
       mov       r11d,r10d
       sub       ebx,[r9+r11*4+10]
       cmp       ebx,7FFFFFFF
       je        short M02_L03
       test      ebx,ebx
       jge       short M02_L04
       add       ebx,7FFFFFFF
       jmp       short M02_L04
M02_L03:
       mov       ebx,7FFFFFFE
M02_L04:
       mov       r11d,r8d
       mov       [r9+r11*4+10],ebx
       mov       [rdx+8],r8d
       mov       [rdx+0C],r10d
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2sd xmm3,xmm3,ebx
       vmulsd    xmm3,xmm3,xmm0
       vmulsd    xmm3,xmm3,xmm1
       vcvttsd2si edx,xmm3
       mov       r8,rax
       mov       r10d,[r8+8]
       inc       r10d
       cmp       r10d,38
       jl        short M02_L05
       mov       r10d,1
M02_L05:
       mov       r9d,[r8+0C]
       inc       r9d
       cmp       r9d,38
       jl        short M02_L06
       mov       r9d,1
M02_L06:
       mov       r11,[r8]
       mov       ebx,[r11+8]
       cmp       r10d,ebx
       jae       near ptr M02_L13
       mov       esi,r10d
       mov       esi,[r11+rsi*4+10]
       cmp       r9d,ebx
       jae       near ptr M02_L13
       mov       ebx,r9d
       sub       esi,[r11+rbx*4+10]
       cmp       esi,7FFFFFFF
       je        short M02_L07
       test      esi,esi
       jge       short M02_L08
       add       esi,7FFFFFFF
       jmp       short M02_L08
M02_L07:
       mov       esi,7FFFFFFE
M02_L08:
       mov       ebx,r10d
       mov       [r11+rbx*4+10],esi
       mov       [r8+8],r10d
       mov       [r8+0C],r9d
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2sd xmm3,xmm3,esi
       vmulsd    xmm3,xmm3,xmm0
       vmulsd    xmm3,xmm3,xmm1
       vcvttsd2si r8d,xmm3
       shl       r8,16
       or        rdx,r8
       mov       r8d,[rax+8]
       inc       r8d
       cmp       r8d,38
       jl        short M02_L09
       mov       r8d,1
M02_L09:
       mov       r10d,[rax+0C]
       inc       r10d
       cmp       r10d,38
       jl        short M02_L10
       mov       r10d,1
M02_L10:
       mov       r9,[rax]
       mov       r11d,[r9+8]
       cmp       r8d,r11d
       jae       short M02_L13
       mov       ebx,r8d
       mov       ebx,[r9+rbx*4+10]
       cmp       r10d,r11d
       jae       short M02_L13
       mov       r11d,r10d
       sub       ebx,[r9+r11*4+10]
       cmp       ebx,7FFFFFFF
       je        short M02_L11
       test      ebx,ebx
       jge       short M02_L12
       add       ebx,7FFFFFFF
       jmp       short M02_L12
M02_L11:
       mov       ebx,7FFFFFFE
M02_L12:
       mov       r11d,r8d
       mov       [r9+r11*4+10],ebx
       mov       [rax+8],r8d
       mov       [rax+0C],r10d
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2sd xmm3,xmm3,ebx
       vmulsd    xmm3,xmm3,xmm0
       vmulsd    xmm3,xmm3,xmm2
       vcvttsd2si eax,xmm3
       shl       rax,2C
       or        rax,rdx
       shr       rax,1
       mov       rdx,7FFFFFFFFFFFFFFF
       cmp       rax,rdx
       je        near ptr M02_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 503
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.MethodsBench.BytesWithout()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFEAFC8FC78]; RandomProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; RandomProof.Subjects.NextBytes(System.Random, Byte[])
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L03
       test      rdx,rdx
       je        short M01_L01
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L02
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       [rsp+28],rax
       mov       [rsp+30],edx
       lea       rdx,[rsp+28]
       call      qword ptr [7FFEAFB6D190]; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
M01_L00:
       nop
       add       rsp,38
       ret
M01_L01:
       mov       ecx,56
       call      qword ptr [7FFEAF8BFD38]
       int       3
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 119
```
```assembly
; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       mov       rbp,[rcx+10]
       mov       r14,[rcx+18]
       mov       r15,[rcx+20]
       cmp       esi,8
       jl        short M02_L01
M02_L00:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       cmp       esi,8
       jl        short M02_L03
       mov       [rbx],rax
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       add       rbx,8
       add       esi,0FFFFFFF8
       cmp       esi,8
       jge       short M02_L00
M02_L01:
       test      esi,esi
       jne       short M02_L04
M02_L02:
       mov       [rcx+8],rdi
       mov       [rcx+10],rbp
       mov       [rcx+18],r14
       mov       [rcx+20],r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       ecx,28
       call      qword ptr [7FFEAF8BF348]
       int       3
M02_L04:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rsp+20],rax
       xor       eax,eax
       cmp       eax,esi
       jge       short M02_L06
M02_L05:
       lea       rdx,[rsp+20]
       movzx     edx,byte ptr [rdx+rax]
       mov       [rbx+rax],dl
       inc       eax
       cmp       eax,esi
       jl        short M02_L05
M02_L06:
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       jmp       short M02_L02
; Total bytes of code 213
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.MethodsBench.BytesWith()
       mov       rdx,rcx
       mov       rcx,[rdx+10]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFEAFC5FC78]; RandomProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; RandomProof.Subjects.NextBytes(System.Random, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L04
       test      rdx,rdx
       je        short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L03
       lea       rbx,[rcx+8]
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
       xor       ebp,ebp
       test      edi,edi
       jle       short M01_L01
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFEAFC5FCC0]; System.Random+CompatPrng.InternalSample()
       mov       [rsi+rbp],al
       inc       ebp
       cmp       ebp,edi
       jl        short M01_L00
M01_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,56
       call      qword ptr [7FFEAF88FD38]
       int       3
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L01
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L01
; Total bytes of code 127
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; RandomProof.Benchmarks.MethodsBench.BytesCrypto()
       mov       rcx,[rcx+18]
       jmp       qword ptr [7FFEAFC7FBB8]; RandomProof.Subjects.CryptoBytes(Byte[])
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.CryptoBytes(Byte[])
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       test      rcx,rcx
       je        short M01_L02
       lea       rdx,[rcx+10]
       mov       eax,[rcx+8]
M01_L00:
       test      eax,eax
       jle       short M01_L01
       mov       [rsp+20],rdx
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FFEAFC7FCD8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       eax,eax
       mov       [rsp+20],rax
M01_L01:
       xor       eax,eax
       mov       [rsp+20],rax
       add       rsp,28
       ret
M01_L02:
       xor       edx,edx
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 68
```
```assembly
; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r8,rsp
       mov       [rbp-58],r8
       mov       r8,rbp
       mov       [rbp-48],r8
       mov       r8d,esi
       mov       rdx,rbx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFEAFD279A8
       mov       [rbp-60],rax
       lea       rax,[M02_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF3F9A4320
       call      rax
M02_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFF0F7EF778],0
       je        short M02_L01
       call      qword ptr [7FFF0F7DD608]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L02
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       ecx,eax
       call      qword ptr [7FFEAFD55C38]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 186
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.MethodsBench.RangeWithout()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE6B23EDA8]; RandomProof.Subjects.NextRange(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextRange(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       near ptr M01_L05
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       near ptr M01_L04
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
       shr       r9,20
       mov       eax,r9d
       imul      rax,3E8
       mov       edx,eax
       cmp       edx,3E8
       jb        short M01_L03
M01_L00:
       shr       rax,20
M01_L01:
       add       rsp,28
       ret
M01_L02:
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
       shr       r9,20
       mov       edx,r9d
       imul      rax,rdx,3E8
       mov       edx,eax
M01_L03:
       cmp       edx,128
       jb        short M01_L02
       jmp       short M01_L00
M01_L04:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L01
M01_L05:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
; Total bytes of code 288
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.MethodsBench.RangeWith()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFE6B22EDA8]; RandomProof.Subjects.NextRange(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextRange(System.Random)
       sub       rsp,28
       vzeroupper
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       add       rcx,8
       call      qword ptr [7FFE6B01EAC0]; System.Random+CompatPrng.InternalSample()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FFE6AE56FF0]
       vmulsd    xmm0,xmm0,qword ptr [7FFE6AE56FF8]
       vcvttsd2si eax,xmm0
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L00
M01_L02:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L00
; Total bytes of code 124
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.MethodsBench.DoubleWithout()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE6B25F018]; RandomProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextDouble(System.Random)
       sub       rsp,28
       vzeroupper
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFE6B03F6D8]; System.Random+XoshiroImpl.NextDouble()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L00
; Total bytes of code 77
```
```assembly
; System.Random+XoshiroImpl.NextDouble()
       vzeroupper
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
       shr       r9,0B
       vcvtusi2sd xmm0,xmm0,r9
       vmulsd    xmm0,xmm0,qword ptr [7FFE6AE86F40]
       ret
; Total bytes of code 92
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.MethodsBench.DoubleWith()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFE6B22F0F0]; RandomProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextDouble(System.Random)
       sub       rsp,28
       vzeroupper
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       add       rcx,8
       call      qword ptr [7FFE6B01EAC0]; System.Random+CompatPrng.InternalSample()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FFE6AE56F40]
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L00
; Total bytes of code 96
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.MethodsBench.Int64Without()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE6B22F030]; RandomProof.Subjects.NextInt64(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextInt64(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFE6B00F6B8]; System.Random+XoshiroImpl.NextInt64()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L00
; Total bytes of code 73
```
```assembly
; System.Random+XoshiroImpl.NextInt64()
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
       shr       rax,1
       mov       rdx,7FFFFFFFFFFFFFFF
       cmp       rax,rdx
       je        short M02_L00
       ret
; Total bytes of code 92
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.MethodsBench.Int64With()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFE6B23F030]; RandomProof.Subjects.NextInt64(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextInt64(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFE6B01FAC8]; System.Random+Net5CompatSeedImpl.NextInt64()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L00
; Total bytes of code 73
```
```assembly
; System.Random+Net5CompatSeedImpl.NextInt64()
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
M02_L00:
       cmp       [rcx],cl
       lea       rdx,[rcx+8]
       mov       r8,rdx
       mov       r10d,[r8+8]
       inc       r10d
       cmp       r10d,38
       jge       near ptr M02_L18
M02_L01:
       mov       r9d,[r8+0C]
       inc       r9d
       cmp       r9d,38
       jge       near ptr M02_L17
M02_L02:
       mov       r11,[r8]
       mov       eax,[r11+8]
       cmp       r10d,eax
       jae       near ptr M02_L22
       mov       ebx,r10d
       mov       ebx,[r11+rbx*4+10]
       cmp       r9d,eax
       jae       near ptr M02_L22
       mov       eax,r9d
       sub       ebx,[r11+rax*4+10]
       cmp       ebx,7FFFFFFF
       je        near ptr M02_L19
M02_L03:
       test      ebx,ebx
       jge       short M02_L04
       add       ebx,7FFFFFFF
M02_L04:
       mov       eax,r10d
       mov       [r11+rax*4+10],ebx
       mov       [r8+8],r10d
       mov       [r8+0C],r9d
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,ebx
       vmovsd    xmm1,qword ptr [7FFE6AE67330]
       vmulsd    xmm0,xmm0,xmm1
       vmovsd    xmm2,qword ptr [7FFE6AE67338]
       vmulsd    xmm0,xmm0,xmm2
       vcvttsd2si eax,xmm0
       mov       r8,rdx
       mov       r10d,[r8+8]
       inc       r10d
       cmp       r10d,38
       jge       near ptr M02_L16
M02_L05:
       mov       r9d,[r8+0C]
       inc       r9d
       cmp       r9d,38
       jge       near ptr M02_L15
M02_L06:
       mov       rsi,[r8]
       mov       r11d,[rsi+8]
       cmp       r10d,r11d
       jae       near ptr M02_L22
       mov       ebx,r10d
       mov       ebx,[rsi+rbx*4+10]
       cmp       r9d,r11d
       jae       near ptr M02_L22
       mov       r11d,r9d
       sub       ebx,[rsi+r11*4+10]
       cmp       ebx,7FFFFFFF
       je        near ptr M02_L20
M02_L07:
       test      ebx,ebx
       jge       short M02_L08
       add       ebx,7FFFFFFF
M02_L08:
       mov       r11d,r10d
       mov       [rsi+r11*4+10],ebx
       mov       [r8+8],r10d
       mov       [r8+0C],r9d
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,ebx
       vmulsd    xmm0,xmm0,xmm1
       vmulsd    xmm2,xmm0,xmm2
       vcvttsd2si r8d,xmm2
       mov       r10d,r8d
       shl       r10,16
       or        rax,r10
       mov       r8d,[rdx+8]
       inc       r8d
       cmp       r8d,38
       jge       near ptr M02_L14
M02_L09:
       mov       r10d,[rdx+0C]
       inc       r10d
       cmp       r10d,38
       jge       near ptr M02_L13
M02_L10:
       mov       r11,[rdx]
       mov       r9d,[r11+8]
       cmp       r8d,r9d
       jae       near ptr M02_L22
       mov       ebx,r8d
       mov       esi,[r11+rbx*4+10]
       cmp       r10d,r9d
       jae       near ptr M02_L22
       mov       r9d,r10d
       sub       esi,[r11+r9*4+10]
       cmp       esi,7FFFFFFF
       je        near ptr M02_L21
M02_L11:
       test      esi,esi
       jge       short M02_L12
       add       esi,7FFFFFFF
M02_L12:
       mov       r9d,r8d
       mov       [r11+r9*4+10],esi
       mov       [rdx+8],r8d
       mov       [rdx+0C],r10d
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,esi
       vmulsd    xmm1,xmm0,xmm1
       vmulsd    xmm0,xmm1,qword ptr [7FFE6AE67340]
       vcvttsd2si edx,xmm0
       mov       r8d,edx
       shl       r8,2C
       or        rax,r8
       shr       rax,1
       mov       r10,7FFFFFFFFFFFFFFF
       cmp       rax,r10
       je        near ptr M02_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L13:
       mov       r10d,1
       jmp       near ptr M02_L10
M02_L14:
       mov       r8d,1
       jmp       near ptr M02_L09
M02_L15:
       mov       r9d,1
       jmp       near ptr M02_L06
M02_L16:
       mov       r10d,1
       jmp       near ptr M02_L05
M02_L17:
       mov       r9d,1
       jmp       near ptr M02_L02
M02_L18:
       mov       r10d,1
       jmp       near ptr M02_L01
M02_L19:
       mov       ebx,7FFFFFFE
       jmp       near ptr M02_L03
M02_L20:
       mov       ebx,7FFFFFFE
       jmp       near ptr M02_L07
M02_L21:
       mov       esi,7FFFFFFE
       jmp       near ptr M02_L11
M02_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 590
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.MethodsBench.BytesWithout()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFE6B25EDF0]; RandomProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; RandomProof.Subjects.NextBytes(System.Random, Byte[])
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L03
       test      rdx,rdx
       je        short M01_L01
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L02
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       [rsp+28],rax
       mov       [rsp+30],edx
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE6B03F2C0]; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
M01_L00:
       nop
       add       rsp,38
       ret
M01_L01:
       mov       ecx,5C
       call      qword ptr [7FFE6AFEED00]
       int       3
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 119
```
```assembly
; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       mov       rbp,[rcx+10]
       mov       r14,[rcx+18]
       mov       r15,[rcx+20]
       cmp       esi,8
       jl        short M02_L01
       nop       dword ptr [rax+rax]
M02_L00:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rbx],rax
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       cmp       esi,8
       jb        short M02_L04
       add       rbx,8
       add       esi,0FFFFFFF8
       cmp       esi,8
       jge       short M02_L00
M02_L01:
       test      esi,esi
       jne       short M02_L03
M02_L02:
       mov       [rcx+8],rdi
       mov       [rcx+10],rbp
       mov       [rcx+18],r14
       mov       [rcx+20],r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rsp+20],rax
       lea       r13,[rsp+20]
       xor       r12d,r12d
       jmp       short M02_L06
M02_L04:
       call      qword ptr [7FFE6AFEE9D0]
       int       3
M02_L05:
       mov       eax,r12d
       movsxd    rdx,r12d
       movzx     edx,byte ptr [rdx+r13]
       mov       [rbx+rax],dl
       inc       r12d
M02_L06:
       cmp       r12d,esi
       jl        short M02_L05
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       jmp       short M02_L02
; Total bytes of code 229
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.MethodsBench.BytesWith()
       mov       rdx,rcx
       mov       rcx,[rdx+10]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFE6B24E940]; RandomProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; RandomProof.Subjects.NextBytes(System.Random, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L04
       test      rdx,rdx
       je        short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L03
       lea       rbx,[rcx+8]
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
       xor       ebp,ebp
       test      edi,edi
       jle       short M01_L01
M01_L00:
       mov       r14d,ebp
       mov       rcx,rbx
       call      qword ptr [7FFE6B03E880]; System.Random+CompatPrng.InternalSample()
       mov       [rsi+r14],al
       inc       ebp
       cmp       ebp,edi
       jl        short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       ecx,5C
       call      qword ptr [7FFE6AFDED00]
       int       3
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L01
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L01
; Total bytes of code 135
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

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; RandomProof.Benchmarks.MethodsBench.BytesCrypto()
       mov       rcx,[rcx+18]
       jmp       qword ptr [7FFE6B23E958]; RandomProof.Subjects.CryptoBytes(Byte[])
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.CryptoBytes(Byte[])
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M01_L01
       lea       rbx,[rcx+10]
       mov       esi,[rcx+8]
M01_L00:
       mov       [rsp+28],rbx
       mov       [rsp+30],esi
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE6B23EBF8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L01:
       xor       ebx,ebx
       xor       esi,esi
       jmp       short M01_L00
; Total bytes of code 59
```
```assembly
; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rbx,rcx
       lea       rcx,[rbp-80]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-60],rdx
       mov       rdx,rbp
       mov       [rbp-50],rdx
       mov       rdx,[rbx]
       mov       r8d,[rbx+8]
       test      r8d,r8d
       jle       short M02_L02
       mov       [rbp-40],rdx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE6B249FF0
       mov       [rbp-70],rax
       lea       rax,[M02_L00]
       mov       [rbp-58],rax
       lea       rax,[rbp-80]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFF3F9A4320
       call      rax
M02_L00:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFECACEA0DC],0
       je        short M02_L01
       call      qword ptr [7FFECACDA3A8]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rcx,[rbp-78]
       mov       [rsi+10],rcx
       test      eax,eax
       jne       short M02_L03
       xor       eax,eax
       mov       [rbp-40],rax
M02_L02:
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
M02_L03:
       mov       ecx,eax
       call      qword ptr [7FFE6B23F1E0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 206
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.MethodsBench.RangeWithout()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE6B13EC70]; RandomProof.Subjects.NextRange(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextRange(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       near ptr M01_L04
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       near ptr M01_L03
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
       shr       r11,20
       mov       eax,r11d
       imul      rax,3E8
       mov       edx,eax
       cmp       edx,3E8
       jb        short M01_L02
M01_L00:
       shr       rax,20
M01_L01:
       add       rsp,28
       ret
M01_L02:
       cmp       edx,128
       jae       short M01_L00
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
       shr       r11,20
       mov       edx,r11d
       imul      rax,rdx,3E8
       mov       edx,eax
       jmp       short M01_L02
M01_L03:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L01
M01_L04:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L01
; Total bytes of code 288
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.MethodsBench.RangeWith()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFE6B15EB98]; RandomProof.Subjects.NextRange(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextRange(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       near ptr M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       add       rcx,8
       call      qword ptr [7FFE6B15EBE0]; System.Random+CompatPrng.InternalSample()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FFE6AE584E0]
       vmulsd    xmm0,xmm0,qword ptr [7FFE6AE584E8]
       vfixupimmsd xmm0,xmm0,[7FFE6AE584F0],0
       vcmpgepd  k1,xmm0,[7FFE6AE58500]
       vcvttsd2si eax,xmm0
       vpbroadcastd xmm0,eax
       vpblendmd xmm0{k1},xmm0,[7FFE6AE58510]
       vmovd     eax,xmm0
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L00
M01_L02:
       xor       edx,edx
       mov       r8d,3E8
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       short M01_L00
; Total bytes of code 167
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.MethodsBench.DoubleWithout()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE6B14EC58]; RandomProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextDouble(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFE6B035B18]; System.Random+XoshiroImpl.NextDouble()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L00
; Total bytes of code 74
```
```assembly
; System.Random+XoshiroImpl.NextDouble()
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
       shr       r11,0B
       vcvtusi2sd xmm0,xmm0,r11
       vmulsd    xmm0,xmm0,qword ptr [7FFE6AE48370]
       ret
; Total bytes of code 89
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.MethodsBench.DoubleWith()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFE6B16EC70]; RandomProof.Subjects.NextDouble(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextDouble(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       add       rcx,8
       call      qword ptr [7FFE6B16ECB8]; System.Random+CompatPrng.InternalSample()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,eax
       vmulsd    xmm0,xmm0,qword ptr [7FFE6AE68390]
M01_L00:
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       short M01_L00
; Total bytes of code 93
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.MethodsBench.Int64Without()
       mov       rcx,[rcx+8]
       jmp       qword ptr [7FFE6B15EB98]; RandomProof.Subjects.NextInt64(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextInt64(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFE6B045AF8]; System.Random+XoshiroImpl.NextInt64()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L00
; Total bytes of code 73
```
```assembly
; System.Random+XoshiroImpl.NextInt64()
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
       shr       rax,1
       mov       rdx,7FFFFFFFFFFFFFFF
       cmp       rax,rdx
       je        short M02_L00
       ret
; Total bytes of code 92
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.MethodsBench.Int64With()
       mov       rcx,[rcx+10]
       jmp       qword ptr [7FFE6B13EB98]; RandomProof.Subjects.NextInt64(System.Random)
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.NextInt64(System.Random)
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L01
       call      qword ptr [7FFE6B026068]; System.Random+Net5CompatSeedImpl.NextInt64()
M01_L00:
       nop
       add       rsp,28
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M01_L00
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M01_L00
; Total bytes of code 73
```
```assembly
; System.Random+Net5CompatSeedImpl.NextInt64()
       push      rsi
       push      rbx
       sub       rsp,28
       vmovsd    xmm0,qword ptr [7FFE6AE38810]
       vmovsd    xmm1,qword ptr [7FFE6AE38818]
       vmovsd    xmm2,qword ptr [7FFE6AE38820]
M02_L00:
       cmp       [rcx],cl
       lea       rdx,[rcx+8]
       mov       r8,rdx
       mov       r10d,[r8+8]
       inc       r10d
       cmp       r10d,38
       jge       near ptr M02_L13
M02_L01:
       mov       r9d,[r8+0C]
       inc       r9d
       cmp       r9d,38
       jge       near ptr M02_L14
M02_L02:
       mov       r11,[r8]
       mov       eax,[r11+8]
       cmp       r10d,eax
       jae       near ptr M02_L25
       mov       ebx,r10d
       mov       ebx,[r11+rbx*4+10]
       cmp       r9d,eax
       jae       near ptr M02_L25
       mov       eax,r9d
       sub       ebx,[r11+rax*4+10]
       cmp       ebx,7FFFFFFF
       je        near ptr M02_L22
M02_L03:
       test      ebx,ebx
       jl        near ptr M02_L15
M02_L04:
       mov       eax,r10d
       mov       [r11+rax*4+10],ebx
       mov       [r8+8],r10d
       mov       [r8+0C],r9d
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2sd xmm3,xmm3,ebx
       vmulsd    xmm3,xmm3,xmm0
       vmulsd    xmm3,xmm3,xmm1
       vfixupimmsd xmm3,xmm3,[7FFE6AE38830],0
       vcmpgepd  k1,xmm3,[7FFE6AE38840]
       vcvttsd2si eax,xmm3
       vpbroadcastd xmm3,eax
       vpblendmd xmm3{k1},xmm3,[7FFE6AE38850]
       vmovd     eax,xmm3
       mov       r8,rdx
       mov       r10d,[r8+8]
       inc       r10d
       cmp       r10d,38
       jge       near ptr M02_L16
M02_L05:
       mov       r9d,[r8+0C]
       inc       r9d
       cmp       r9d,38
       jge       near ptr M02_L17
M02_L06:
       mov       rsi,[r8]
       mov       r11d,[rsi+8]
       cmp       r10d,r11d
       jae       near ptr M02_L25
       mov       ebx,r10d
       mov       ebx,[rsi+rbx*4+10]
       cmp       r9d,r11d
       jae       near ptr M02_L25
       mov       r11d,r9d
       sub       ebx,[rsi+r11*4+10]
       cmp       ebx,7FFFFFFF
       je        near ptr M02_L23
M02_L07:
       test      ebx,ebx
       jl        near ptr M02_L18
M02_L08:
       mov       r11d,r10d
       mov       [rsi+r11*4+10],ebx
       mov       [r8+8],r10d
       mov       [r8+0C],r9d
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2sd xmm3,xmm3,ebx
       vmulsd    xmm3,xmm3,xmm0
       vmulsd    xmm3,xmm3,xmm1
       vfixupimmsd xmm3,xmm3,[7FFE6AE38830],0
       vcmpgepd  k1,xmm3,[7FFE6AE38840]
       vcvttsd2si r8d,xmm3
       vpbroadcastd xmm3,r8d
       vpblendmd xmm3{k1},xmm3,[7FFE6AE38850]
       vmovd     r10d,xmm3
       mov       r9d,r10d
       shl       r9,16
       or        rax,r9
       mov       r8d,[rdx+8]
       inc       r8d
       cmp       r8d,38
       jge       near ptr M02_L19
M02_L09:
       mov       r10d,[rdx+0C]
       inc       r10d
       cmp       r10d,38
       jge       near ptr M02_L20
M02_L10:
       mov       r9,[rdx]
       mov       r11d,[r9+8]
       cmp       r8d,r11d
       jae       near ptr M02_L25
       mov       ebx,r8d
       mov       esi,[r9+rbx*4+10]
       cmp       r10d,r11d
       jae       near ptr M02_L25
       mov       r11d,r10d
       sub       esi,[r9+r11*4+10]
       cmp       esi,7FFFFFFF
       je        near ptr M02_L24
M02_L11:
       test      esi,esi
       jl        near ptr M02_L21
M02_L12:
       mov       r11d,r8d
       mov       [r9+r11*4+10],esi
       mov       [rdx+8],r8d
       mov       [rdx+0C],r10d
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2sd xmm3,xmm3,esi
       vmulsd    xmm3,xmm3,xmm0
       vmulsd    xmm3,xmm3,xmm2
       vfixupimmsd xmm3,xmm3,[7FFE6AE38830],0
       vcmpgepd  k1,xmm3,[7FFE6AE38840]
       vcvttsd2si edx,xmm3
       vpbroadcastd xmm3,edx
       vpblendmd xmm3{k1},xmm3,[7FFE6AE38850]
       vmovd     r8d,xmm3
       mov       r10d,r8d
       shl       r10,2C
       or        rax,r10
       shr       rax,1
       mov       r9,7FFFFFFFFFFFFFFF
       cmp       rax,r9
       je        near ptr M02_L00
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L13:
       mov       r10d,1
       jmp       near ptr M02_L01
M02_L14:
       mov       r9d,1
       jmp       near ptr M02_L02
M02_L15:
       add       ebx,7FFFFFFF
       jmp       near ptr M02_L04
M02_L16:
       mov       r10d,1
       jmp       near ptr M02_L05
M02_L17:
       mov       r9d,1
       jmp       near ptr M02_L06
M02_L18:
       add       ebx,7FFFFFFF
       jmp       near ptr M02_L08
M02_L19:
       mov       r8d,1
       jmp       near ptr M02_L09
M02_L20:
       mov       r10d,1
       jmp       near ptr M02_L10
M02_L21:
       add       esi,7FFFFFFF
       jmp       near ptr M02_L12
M02_L22:
       mov       ebx,7FFFFFFE
       jmp       near ptr M02_L03
M02_L23:
       mov       ebx,7FFFFFFE
       jmp       near ptr M02_L07
M02_L24:
       mov       esi,7FFFFFFE
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 746
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.MethodsBench.BytesWithout()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFE6B16EC58]; RandomProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; RandomProof.Subjects.NextBytes(System.Random, Byte[])
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L03
       test      rdx,rdx
       je        short M01_L02
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+XoshiroImpl
       cmp       [rcx],rax
       jne       short M01_L01
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       [rsp+28],rax
       mov       [rsp+30],edx
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE6B055628]; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
M01_L00:
       nop
       add       rsp,38
       ret
M01_L01:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L00
M01_L02:
       mov       ecx,58
       call      qword ptr [7FFE6ADBFB28]
       int       3
M01_L03:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L00
; Total bytes of code 119
```
```assembly
; System.Random+XoshiroImpl.NextBytes(System.Span`1<Byte>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx+8]
       mov       rbp,[rcx+10]
       mov       r14,[rcx+18]
       mov       r15,[rcx+20]
       cmp       esi,8
       jl        short M02_L01
M02_L00:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rbx],rax
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       cmp       esi,8
       jb        short M02_L03
       add       rbx,8
       add       esi,0FFFFFFF8
       cmp       esi,8
       jge       short M02_L00
M02_L01:
       test      esi,esi
       jne       short M02_L04
M02_L02:
       mov       [rcx+8],rdi
       mov       [rcx+10],rbp
       mov       [rcx+18],r14
       mov       [rcx+20],r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       call      qword ptr [7FFE6AFC77B0]
       int       3
M02_L04:
       lea       rax,[rbp+rbp*4]
       rol       rax,7
       lea       rax,[rax+rax*8]
       mov       [rsp+20],rax
       xor       eax,eax
M02_L05:
       cmp       eax,esi
       jge       short M02_L06
       lea       rdx,[rsp+20]
       movsxd    r8,eax
       movzx     edx,byte ptr [rdx+r8]
       mov       [rbx+rax],dl
       inc       eax
       jmp       short M02_L05
M02_L06:
       mov       rax,rbp
       shl       rax,11
       xor       r14,rdi
       xor       r15,rbp
       xor       rbp,r14
       xor       rdi,r15
       xor       r14,rax
       rol       r15,2D
       jmp       short M02_L02
; Total bytes of code 210
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.MethodsBench.BytesWith()
       mov       rdx,rcx
       mov       rcx,[rdx+10]
       mov       rdx,[rdx+18]
       jmp       qword ptr [7FFE6B14EC58]; RandomProof.Subjects.NextBytes(System.Random, Byte[])
; Total bytes of code 17
```
```assembly
; RandomProof.Subjects.NextBytes(System.Random, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rax,offset MT_System.Random
       cmp       [rcx],rax
       jne       short M01_L04
       test      rdx,rdx
       je        short M01_L03
       mov       rcx,[rcx+8]
       mov       rax,offset MT_System.Random+Net5CompatSeedImpl
       cmp       [rcx],rax
       jne       short M01_L02
       lea       rbx,[rcx+8]
       lea       rsi,[rdx+10]
       mov       edi,[rdx+8]
       xor       ebp,ebp
       test      edi,edi
       jle       short M01_L01
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFE6B14ECA0]; System.Random+CompatPrng.InternalSample()
       mov       [rsi+rbp],al
       inc       ebp
       cmp       ebp,edi
       jl        short M01_L00
M01_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       short M01_L01
M01_L03:
       mov       ecx,58
       call      qword ptr [7FFE6AD9FB28]
       int       3
M01_L04:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       jmp       short M01_L01
; Total bytes of code 127
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

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; RandomProof.Benchmarks.MethodsBench.BytesCrypto()
       mov       rcx,[rcx+18]
       jmp       qword ptr [7FFE6B13EB80]; RandomProof.Subjects.CryptoBytes(Byte[])
; Total bytes of code 10
```
```assembly
; RandomProof.Subjects.CryptoBytes(Byte[])
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M01_L02
       lea       rbx,[rcx+10]
       mov       edx,[rcx+8]
M01_L00:
       test      edx,edx
       jle       short M01_L01
       mov       [rsp+28],rbx
       mov       rcx,rbx
       call      qword ptr [7FFE6B13ECA0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       eax,eax
       mov       [rsp+28],rax
M01_L01:
       xor       eax,eax
       mov       [rsp+28],rax
       add       rsp,30
       pop       rbx
       ret
M01_L02:
       xor       ebx,ebx
       xor       edx,edx
       jmp       short M01_L00
; Total bytes of code 68
```
```assembly
; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
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
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r8,rsp
       mov       [rbp-58],r8
       mov       r8,rbp
       mov       [rbp-48],r8
       mov       r8d,esi
       mov       rdx,rbx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFE6B1DD2B0
       mov       [rbp-60],rax
       lea       rax,[M02_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFF3F9A4320
       call      rax
M02_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFECACFD624],0
       je        short M02_L01
       call      qword ptr [7FFECACEB408]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L02
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
M02_L02:
       mov       ecx,eax
       call      qword ptr [7FFE6B224DC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 186
```

