
CSC=csc
CSC=mcs

PROG=wmctrl.exe



all: $(PROG) test

$(PROG): wmctrl.cs
	$(CSC) wmctrl.cs


test:
	$(PROG) -h
	$(PROG) -l
	$(PROG) -a gvim
