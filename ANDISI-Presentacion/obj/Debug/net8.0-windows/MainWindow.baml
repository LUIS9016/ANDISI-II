   M S B A M L   `   `   `  ����  ANDISI-Presentacion%    ANDISI_Presentacion.Main_Window   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          �Name$  	ANDISI_II��5   	    � WindowStyle$
 None=�5   	    � WindowState$ 	Maximized=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Title$ 	ANDISI II��5
   	    � 	Resources 5         ShowPanelStoryboard �� 
TargetName �� TargetProperty W� From		 W� To
 g� Duration  HidePanelStoryboard��%  &	        &	 �     �� 5   
   .��5      W� $ DockMenu��6   $ Opacity�5       05      	 16#   $
 0:0:0.5D�6*   5      �� 5   
   .��5      W� $ DockMenu��6   $ Opacity�5       15      	 06#   $
 0:0:0.5D�6*   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   ]� -   5         ]�Name$ DockMenu��5      $��0��6&     bg-principal#��[ 66    J� Opacity$ 1Q�6a   .+�5      � $��0,0,10,0q�6    � RowDefinitions 5      �� 5      $
��1.5* �6$   �� 5       $	��10* �6$   �� 5!      $
��0.8* �6$   .+�5$      ��  �� Orientation$ 
Horizontal=�6   $��0��67   $��	10,0,0,20q�6D   .+�5%      �� $��/RECURSOS/IMG/13A.png��6   $��80��6;   $��80��6G    J� RenderTransformOrigin$	 1,1&�6R   �� 5'      $
��ANDI��6    
�������$��20(�5)      $��
Montserrat)�5*      $��Medium"�5+      $��Center=�5,      $��Right=�5-      $��10,0,0,0q�5.      50      �� 52      -   5         ��Name$ Scroll_menu��52      
������ $��1��6M   $��Hidden=�6Z   $��Hidden=�6   53      �� 55      $��2��6   .+�56      �� -   5         ��Name$ Close��56   8   $
��left=�6   $��
20,20,0, 0q�6G     btn-cerrar-sesion#��[ 6\   $��17(�6�   ��6�   �� *CerrarSesion+57      58      5:      5;      � 5>   
   $��1��6    5?      �� 5@      $
��auto �6    �� 5A      $	��10* �6    .+�5C      ��   
Border-bar#��[ 6   ._�5D      �� $ 
Horizontal=�6   $
��Left=�67   $��0��6R   .+�5E      �� -   5        $ HamburgerButton��5E        HamburgerButtonStyle#��[ 67   ��6e   �� *HamburgerCommand+�� 5F      -   5        $ ExpandAllButton��5F        
btn-expand#��[ 67   ��6]   �� *ExpandAllCommand+5G      5H      � 5I      $��1��6   ��5J      �� 5K       �� ImageSource$ /RECURSOS/IMG/13.png��6!    j� Stretch$ Uniform=�6D    �� Opacity$	 0.2Q�6V   .+�5M      �� -   5         ��Name$ content_main��5M   "   5N      5O      5P      5Q      