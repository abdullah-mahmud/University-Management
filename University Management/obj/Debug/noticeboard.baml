   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   T PMahApps.Metro, Version=1.2.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	    University Management'   !University_Management.noticeboard   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   -   5          � Title$  Notice Board��5      $	��600��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66    � Icon$ Pics/logo.png��6[    � 
ResizeMode$ CanMinimize=�5   	   (  "MahApps.Metro.Controls.MetroWindow   	GlowBrush �	#FF0C8181$��1q�68   .��5      �  J� RenderTransformOrigin$ 
0.335,0.38&�6   .+�5	   
   �� -   5         ��Name$ scrollviewer��5	      $
��Auto=�6-   $��40,56,209,157q�6P   .��5
      �� -   5         ��Name$ txt_receive_msg��5
      ���	#FFA9F99C$��15(�6H   5      5      �� 5   
   -   5         ��Name$ txt_send_msg��5      	 �� AcceptsReturn	 . $
��Left=�6=   $��93��6�   $��
40,434,0,0q�6�   
 �� TextWrapping$

 Wrap=�6�   $	��Top=�6�   $	��543��6�   �� 5   
   -   5         ��Name$ btn_send_msg��5      $
��Left=�6D   $��611,464,0,0q�6_   $	��Top=�6t   $��71��6�   $��32��6�   $��0q�6�   $��14(�6�   ��5      �� 5       �� ImageSource$ Pics/Send.png��6    j� Stretch$ Uniform=�69   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ���� 63   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   �� #��z��6)   ._�5   &   �� $��Center=�67   $��Center=�6T   5   #   5      5      5       5"      �� 5#   
   $��    Message��6   $
��Left=�6&   $��
261,25,0,0q�6A   $	��Top=�6U   $��93��6m   $
��Bold"�6x   �� 5$   
   -   5        $
��Left=�5$      $��
607,56,0,0q�6-   $	��Top=�6A   $��75��6Y   $��43��6~   ��5%      �� 5&      $ Pics/back.png��6   $ Uniform=�69   ��5(      �� 5)      " ��6   .�5*      ��  � ��
 ���� 63   �� 5+       � �� 5,      �� 5-      " ��6.   .R�5.   "   �� #��z��6)   ._�5/   &   �� $��Center=�67   $��Center=�6T   50   #   51      53      55      57      �� 58   
   -   5        $ clear_button��58      $
��Left=�6(   $��
697,56,0,0q�6C   $	��Top=�6W   $��75��6o   $��43��6�   ��59      �� 5:      $ Pics/clear.png��6   $ Uniform=�6:   ��5<      �� 5=      " ��6   .�5>      ��  � ��
 ���� 63   �� 5?       � �� 5@      �� 5A      " ��6.   .R�5B   "   �� #��z��6)   ._�5C   &   �� $��Center=�67   $��Center=�6T   5D   #   5E      5G      5I      5K      �� 5L   
   $
��Back��6   $
��Left=�6   $��
628,25,0,0q�6:   $	��Top=�6N   $ 	0.368,0.5&�6f   ���	#FF242E21$
��Bold"�6�   �� 5M   
   $��Clear Notice��6   $
��Left=�6'   $��
697,25,0,0q�6B   $	��Top=�6V   $ 	0.368,0.5&�6n   ���	#FFAA3A28$
��Bold"�6�   5P      5Q      