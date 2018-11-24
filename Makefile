#Makefile for test.cs

test.exe: test.cs
	@gmcs test.cs 

clean:
	@rm -f test.exe
release:
$(info /------------------------------------/)
$(info /      ***Created [./test.exe]***    /)
$(info /------------------------------------/)
