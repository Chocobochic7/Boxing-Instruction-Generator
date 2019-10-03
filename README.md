# Boxing Instruction Generator
C# code that outputs random boxing instructions for different levels

There are three sections of the output; low, medium, high. each section pulls from a set of arrays corresponding with its levels and the levels below it.

for example the medium level section will have pulled instructions from both the medium level and the low level arrays, while the low level section will just pull from the low level array.

each individual section will not have any repeats of instruction but different sections can have repeat instructions.

each section is more likely to pull from its level of array so the section is mostly that level with other levels mixed in.
this code only has 3 sections.

there are 10 instructions in each section.

there are 10 instructions in the low and medium arrays and 5 in the high array.

```
for the instructions:

1- left jab
2- right jab
3- left hook
4- right hook
5- left uppercut
6- right uppercut
duck- duck under as if you are ducking under a fence
slip- pull upper torso back and to the side as if dodging a jab.
```

Code under program.cs
