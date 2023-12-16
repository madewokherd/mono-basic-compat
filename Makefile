
VBC=vbc
SN=sn

SRCS = \
	AssemblyInfo.vb

all: Microsoft.VisualBasic.Compatibility.dll
.PHONY: all

Microsoft.VisualBasic.Compatibility.dll: $(SRCS)
	$(VBC) -target:library -debug+ -out:$@ $(SRCS)
	$(SN) -R $@ mono.snk

