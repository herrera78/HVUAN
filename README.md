# HVUAN (Humanos Virtuales Universidad Antonio Nariño)
This is a virtual agent interaction framework for Spanish speaking virtual humans (a.k.a embodied conversational agents). 
It relies on UTEP's VAIF (https://www.youtube.com/channel/UCeNXKQvJzFep08mEc2e7-Ig) and Windows Cortana, among others.

To create a VH from scratch without a graphic designer:

Software Installation:
1. Download Makehuman from http://www.makehumancommunity.org/content/downloads.html
2. Download Blender from https://www.blender.org/download/
3. Download MakeHuman eXchange format 2 plugins for Makehuman and Blender from https://bitbucket.org/Diffeomorphic/mhx2-makehuman-exchange/downloads/. See plugin installation instructions at https://bitbucket.org/Diffeomorphic/mhx2-makehuman-exchange
4. In the import_runtime_mhx2 folder added to Blender, in the path data > hm8 > faceshapes, replace visemes.mxa with the visemes.mxa file included in this project. 

Steps:
1. Create a virtual human (VH) in Makehuman to suit your needs.
2. Export VH as MHX2 format
3. Import MHX2 file in Blender
  a. Select MHX2 file, then check Override Exported Data checkbox
  b. Check Face Shapes checkbox, then Face Shape Drivers checkbox
  c. Click Import Button
4. In the scene hierarchy, expand the VH object hierarchy, selecting the :Body component, represented by an inverted triangle. This enables the SHape Keys
5. In the MHX2 Runtime pane on the left, select Visemes. 
6. Repeat the following steps with all the visemes in the pane (ou, oh, ih, E, aa, RR, nn, SS, CH, kk, DD, TH, FF, PP, sil):
  a. Select the next viseme
  b. In Shape Keys, in the menu under the inverted triangle on the right below the minus sign, select "+ New Shape From Mix"
  c. Rename the new key with the viseme name.
  d. Move the new key using the arrows to the beginning of the list after the Basis.
7. Once step 6 is completed, you should have the Shape Keys in the correct order after the Basis Shape Key.
8. Export the VH as FBX. Make sure you deselect "Apply Modifiers" in the Geometries Tab under Export FBX Pane on the left.
