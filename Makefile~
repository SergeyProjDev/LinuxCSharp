#Makefile for test.cs

all: run

test.exe: test.cs
	@gmcs test.cs 

clean:
	@rm -f test.exe

run: test.exe
	@mono test.exe
