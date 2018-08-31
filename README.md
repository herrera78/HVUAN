# HVUAN (Humanos Virtuales Universidad Antonio Nariño)
This is a virtual agent interaction framework for Spanish speaking virtual humans (a.k.a embodied conversational agents). 
It relies on UTEP's VAIF (https://www.youtube.com/channel/UCeNXKQvJzFep08mEc2e7-Ig) and Windows Cortana, among others.

To create a VH from scratch without a graphic designer:

Software Installation:
Download Makehuman from http://www.makehumancommunity.org/content/downloads.html
Download Blender from https://www.blender.org/download/
Download MakeHuman eXchange format 2 plugins for Makehuman and Blender from https://bitbucket.org/Diffeomorphic/mhx2-makehuman-exchange/downloads/
See plugin installation instructions at https://bitbucket.org/Diffeomorphic/mhx2-makehuman-exchange

Steps:
1. Create a virtual human (VH) in Makehuman to suit your needs.
2. Export VH as MHX2 format
3. Import MHX2 file in Blender
  a. Select MHX2 file, then check Override Exported Data checkbox
  b. Check Face Shapes checkbox, then Face Shape Drivers checkbox
  c. Click Import Button
4. In the scene hierarchy, expand the VH object hierarchy, selecting the :Body component, represented by an inverted triangle. This enables the SHape Keys
5. In the MHX2 Runtime pane on the left, select Visemes. 
