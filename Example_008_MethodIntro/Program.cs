﻿int a1 = 34;
int b1 = 12;
int c1 = 45;
int a2 = 18;
int b2 = 56;
int c2 = 87;
int a3 = 23;
int b3 = 19;
int c3 = 41;

int max = a1;

if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);