   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   T PMahApps.Metro, Version=1.2.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	    University Management&    University_Management.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  University Management��5   	   $	��350��6'   $	��425��64    � WindowStartupLocation$ CenterScreen=�6@    � Icon$ Pics/logo.png��6e    � 
ResizeMode$ CanMinimize=�5   	   (  "MahApps.Metro.Controls.MetroWindow   	GlowBrush �	#FF0C8181$��1q�68   .��5      �  � RowDefinitions 5	   
   �� 5
      $	��29* �6   �� 5      $	��28* �6   �� 5      $	��67* �6   �� 5      $
��119* �6   �� 5      $	��50* �6   �� 5      $	��26* �6    � ColumnDefinitions 5   
   �� 5      $	��33* �6   �� 5      $	��64* �6   �� 5      $
��320* �6   .+�5   
   �� $��Center=�6   $��0��6-   $��2��6:   $��2��6J   $��Center=�6[   $��42��6v   $	��318��6�   $��1,8,1,7q�6�   .��5      �  J� SnapsToDevicePixels . .+�5      �� $��North Western University��6   $��25(�6<   $��Normal&�6J   5      5      �� 5   
   $��Pics/logo.png��6   $��Uniform=�6'   $��1��69   $��0��6I   $��2��6V   �� 5   
   $��5��6   $��0��6!   $��3��61   
����������	#FF45B6BB.@�5      �� .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5       �� $$��University Management v1.0 || ��6    ���	#FF0B1D1D$��SemiCondensed&�6]   6{   �� 5!      ���	#FF0C2032�� 5"      $�� ?�6    .�6/   Copyrights© Team AndWin ||6K   5#      �� 5$      $��           ��6    �� 5%      -   5        	 ��Name$	 	txt_clock��5%       ���	#FF09192763   5&      5'      5(      �� 5)   
   -   5        $��2��5)      $��Student��6%   $��1��67   $
��Left=�6G   $��	10,10,0,0q�6b   $��3��6u   $	��Top=�6�   $��83��6�   $��83��6�   $��0q�6�   $��14(�6�   ��5*      �� 5+      
 �� EndPoint$
 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5,      �  � Color$ 	#FF238319��6#    � Offset$ 0Q�65   � 5-      $ 	#FF70B969��6#   $ 1Q�65   5.       J� Effect 50      3  -System.Windows.Media.Effects.DropShadowEffect  51         Color$ 	#FF1F914E��6#      
BlurRadius$ 20Q�65      Opacity$	 0.7Q�6E   53      �� 54   
   -   5        $��Admin��54      $��2��6!   $
��Left=�61   $��	65,10,0,0q�6L   $��3��6_   $	��Top=�6l   $��83��6�   $��83��6�   $��0q�6�   $��14(�6�   ��55      �� 56      $
 0.5,1&�6&   $ 0.5,0&�67   .��57      � $ 	#FF274B8B��6#   $ 0Q�65   � 58      $ 	#FF849FCD��6#   $ 1Q�65   59       5;        5<      $ 	#FF365BAA��6#   $ 20Q�65   $	 0.7Q�6E   5>      �� 5?   
   -   5        $��Faculty��5?      $��2��6#   $
��Left=�63   $��
191,10,0,0q�6N   $��3��6b   $	��Top=�6o   $��83��6�   $��83��6�   $��0q�6�   $��14(�6�   ��5@      �� 5A      $
 0.5,1&�6&   $ 0.5,0&�67   .��5B      � $ 	#FF9C2F2F��6#   $ 0Q�65   � 5C      $ 	#FF975353��6#   $ 1Q�65   5D       5F        5G      $ 	#FFD17458��6#   $ 20Q�65   $	 0.7Q�6E   5I      �� 5J   
   $��1��6   $��13(�6$   $
��Left=�62   $��	10,35,0,0q�6M   $��2��6`   $
��Wrap=�6m   $$��Please Select Your Portal ....��6�   $	��Top=�6�   $��2��6�   $��22��6�   $	��329��6�    5K        5L      5N      5Q      5R      