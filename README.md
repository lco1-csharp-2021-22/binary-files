# binary-files
Using bitwise operators and Binary file formats.  

## Background 
We've been looking at using the `&`, `|` and `^` operators to perform bitwise operators on integer values (stored in binary, displayed in denary). 

The BMP file format is summarised [here](http://www.fastgraph.com/help/bmp_header_format.html).

## Sample C# 

```csharp
using System;
using System.IO;

namespace BitmapFiles.App
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] logo = File.ReadAllBytes("sps.bmp");
            byte first = logo[0];
            byte second = logo[1];

            char b = 'B';
            char m = 'M';

            int res1 = first ^ (byte)b;
            int res2 = second ^ (byte)m;
        }
    }
}
```

## Tasks 

Using the System.File object (and its ReadAllBytes function) unpack this bitmap file and summarise its header's data.

The code should first validate that it is actually a bitmap. 

This summary should include: dimensions, colour summary and so on. 

## Reminder 

1. Clone this repo to your local machine - you should have a root folder for all the GitHub assignment clones 
1. Create a Visual Studio solution in the sub-folder for this clone - you should notice in Github Desktop that these new files appear in the changes list. (NB. I've nominated this repo as a Visual Studio one, so all the extra temporary files and folders, e.g. including all the build files, shouldn't get uploaded - that saves on space.)
1. Add the graphics files to the project - make sure to update their Copy To Output property to "newer" or "always" 
2. Away you go! 

## Extension

### 0. AdventOfCode 

On Wednesday lunchtime the Competive Coding Group will be looking at [Puzzle 12 from 2017](https://adventofcode.com/2017/day/12) as they prepare for this year's Advent of Code. Do feel free to look at that puzzle instead and leave this assignment until tomorrow/homework (if you're sure about what's needed). 

### 1. Steganography 

[Steganography](https://en.wikipedia.org/wiki/Steganography) is the practice of hiding a message within a larger object. 

Create two functions: the first should take a bitmap (i.e. the name of a file( and a word and, according to optional parameters, rewrite the bitmap file, 'hiding' the word in the outputted file. The other function should take in the name of the written file (and the optional parameters) and return the word that was hidden.

At the primary level, changing a particular byte somewhere in the image to an ascii value of a character would suffice, but it is likely to end up with an obvious flaw in the image.

At a secondary level, you should be able to change individual bits - which would be less visible to the human eye.

### 2. With a JPG 

Do the same but for the attached JPG file.
