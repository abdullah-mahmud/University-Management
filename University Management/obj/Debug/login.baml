   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   T PMahApps.Metro, Version=1.2.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	    University Management!   University_Management.login   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$   ��5   	   $	��300��6   $	��400��6   $��1q�6+   (  "MahApps.Metro.Controls.MetroWindow   	GlowBrush �	#FF3BBAD6 � 
ResizeMode$ CanMinimize=�5   	    � WindowStartupLocation$ CenterScreen=�6"   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $	��23* �6   �� 5      $	��61* �6   �� 5      $	��60* �6   �� 5      $
��185* �6   �� 5      $	��63* �6    � RowDefinitions 5   
   �� 5      $	��28* �6   �� 5      $	��28* �6   �� 5      $	��38* �6   �� 5      $	��32* �6   �� 5      $	��32* �6   �� 5      $	��78* �6   �� 5      $	��26* �6   .+�5   
   �� $��Center=�6   $��0��6-   $��2��6:   $��2��6J   $��Center=�6[   $��42��6v   $	��318��6�   $��	2,8,-12,8q�6�   $��3��6�   .��5      �  J� SnapsToDevicePixels . .+�5      �� $��North Western University��6   $��25(�6<   $��Normal&�6J   5      5      �� 5   
   $��Pics/logo.png��6   $��Uniform=�6'   $��1��69   $��0��6I   $��2��6V   �� 5    
   $��User ID��6   $��14(�6"   $��1��60   $��3��6@   $��2��6M   $��SemiBold"�6a   �� 5!   
   $��Password��6   $��14(�6#   $��1��61   $��4��6A   $��2��6N   $��SemiBold"�6b   �� 5"   
   -   5         ��Name$ id��5"      $��3��6   $��3��6.   $��18��6;   $��Center=�6G   .��6c    J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$      	   Color$	 	#FFD12424��6#   
   
BlurRadius$
 20Q�65   .��5%      5&      G� 5'   
   -   5         G�Name$ password��5'      $��3��6(   $��4��68   $��18��6E   $��Center=�6Q    5(        5)      $	 	#FFD12424��6#   $
 20Q�65   5+      �� 5,   
   $��6��6   $��0��6!   $��5��61   
����������	#FF45B6BB.@�5-      �� .��5.      ��  �� Orientation$ 
Horizontal=�6   .+�5/      �� $$��University Management v1.0 || ��6    ���	#FF0B1D1D$��SemiCondensed&�6]   6{   �� 50      ���	#FF0C2032�� 51      $�� ?�6    .�6/   Copyrights© Team AndWin ||6K   52      �� 53      $��  ��6    �� 54      -   5         ��Name$ 	txt_clock��54       ���	#FF09192763   55      56      57      �� 58   
   -   5        $��Log in��58      $��3��6"   $
��Left=�62   $��	10,21,0,0q�6M   $��5��6`   $	��Top=�6m   $��75��6�   6�   �� 59   
   -   5        $��Cancel��59      $��3��6"   $
��Left=�62   $��
100,21,0,0q�6M   $��5��6a   $	��Top=�6n   $��75��6�   6�   �� 5:   
   -   5         ��Name$ new_account��5:      $��New student? register��6&   $��3��6F   $
��Left=�6V   $��	10,51,0,0q�6q   $��5��6�   $	��Top=�6�   $	��165��6�   ���	#FF0B1D91$��0q�6�   6�   5;      5<      