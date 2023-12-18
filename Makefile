
VBC=vbc
SN=sn
CPP=cpp

SRCS = \
	AssemblyInfo.vb \
	Microsoft.VisualBasic.Compatibility.VB6/BaseControlArray.vb \
	Microsoft.VisualBasic.Compatibility.VB6/LabelArray.generated.vb

all: Microsoft.VisualBasic.Compatibility.dll
.PHONY: all

%.generated.vb: %.vb.cpp Microsoft.VisualBasic.Compatibility.VB6/ControlArrayCommon.vb.h 
	$(CPP) -P -w $< -o $@

Microsoft.VisualBasic.Compatibility.dll: $(SRCS)
	$(VBC) -target:library -debug+ -out:$@ $(SRCS)
	$(SN) -R $@ mono.snk

