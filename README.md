## About Word Frequency Table

Word Frequency Table finds the _k_ most common words in any given file. A word is defined as consecutive sequences of ASCII alphabetical letters (A-Za-z). Examples of words include A, AA, AAaa, and aAa.

## Instructions for how to develop, use, and test the code.

Assuming the C\#, F\# and Node compilers are on the current PATH, you may type the following into your terminal.
```
$ csc word-freq-table.cs
$ word-freq-table filename k
```
```
$ fsc word-freq-table.fs
$ word-freq-table filename k
```
```
$ node word-freq-table.cs filename k
```
Where `filename` is the text file you are analysing, and `k` is the maximum number of words printed.
